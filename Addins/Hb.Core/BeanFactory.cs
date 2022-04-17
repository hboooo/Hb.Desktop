using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity;
using Unity.Interception.ContainerIntegration;
using Unity.ServiceLocation;

namespace Hb.Core
{
    public class BeanFactory
    {
        private static IUnityContainer container = new UnityContainer();
        private static Interception interceptor = null;

        static BeanFactory()
        {
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(container));
        }

        public static void Clear()
        {
            try
            {
                if (container != null)
                {
                    container.Dispose();
                    container = null;
                    interceptor = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static IUnityContainer Default
        {
            get
            {
                if (container == null)
                {
                    container = new UnityContainer();
                }
                return container;
            }
        }

        public static Interception Interceptor
        {
            get
            {
                if (interceptor == null)
                {
                    interceptor = BeanFactory.Default.AddNewExtension<Interception>().Configure<Interception>();
                }

                return interceptor;
            }
        }

    }
}
