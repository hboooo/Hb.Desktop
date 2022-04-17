using System;
using Unity;
using Unity.Interception.Interceptors.TypeInterceptors.VirtualMethodInterception;

namespace Hb.Core
{
    public class MvvmFactory
    {
        public static T Create<T>()
        {
            BeanFactory.Default.RegisterType<T>();
            BeanFactory.Interceptor.SetInterceptorFor<T>(new VirtualMethodInterceptor());
            return (T)BeanFactory.Default.Resolve<T>();
        }
        
        public static object CreateType(Type type)
        {
            BeanFactory.Default.RegisterType(type);
            BeanFactory.Interceptor.SetInterceptorFor(type, new VirtualMethodInterceptor());
            return BeanFactory.Default.Resolve(type);
        }

        private static EventHandler<TimeoutValidationEventArgs> f_TimeoutValidation;
        public static event EventHandler<TimeoutValidationEventArgs> TimeoutValidation
        {
            add
            {
                f_TimeoutValidation += value;
            }
            remove
            {
                f_TimeoutValidation -= value;
            }
        }
        public static void OnTimeoutValidation(object sender, TimeoutValidationEventArgs e)
        {
            f_TimeoutValidation?.Invoke(sender, e);
        }
    }
}
