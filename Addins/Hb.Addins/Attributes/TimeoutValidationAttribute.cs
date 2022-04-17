using System;
using System.Reflection;
using Unity;
using Unity.Interception.Interceptors.TypeInterceptors.VirtualMethodInterception;
using Unity.Interception.PolicyInjection.Pipeline;
using Unity.Interception.PolicyInjection.Policies;

namespace Hb.Addins.Attributes
{
    /// <summary>
    /// 操作前超时验证拦截器
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class TimeoutValidationAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return new TimeoutValidationCallHandle();
        }
    }

    public class TimeoutValidationCallHandle : ICallHandler
    {
        public int Order { get; set; }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            var vmi = input as VirtualMethodInvocation;
            try
            {
                var invokeMethod = vmi.MethodBase as MethodInfo;
                var args = new TimeoutValidationEventArgs();
                MvvmFactory.OnTimeoutValidation(vmi, args);
                if (args.IsHandled == true)
                {
                    IMethodReturn result = getNext().Invoke(input, getNext);
                    return result;
                }
                else
                {
                    return vmi.CreateMethodReturn(false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return vmi.CreateMethodReturn(true);
        }
    }
}
