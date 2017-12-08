using System;
using Unity;
using Unity.Registration;

namespace DependencyInjectionPrototype.Shared
{
    public abstract class IocBootstrapper
    {
        public abstract InjectionContainer GetContainer();

        protected InjectionContainer GenerateInjectionContainer(IUnityContainer ioc)
        {
            var ic = new InjectionContainer();

            foreach (IContainerRegistration registration in ioc.Registrations)
            {
                Type t = registration.RegisteredType;
                object o = ioc.Resolve(t, null);
                ic.Add(t, o);
            }

            return ic;
        }
    }
}
