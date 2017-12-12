using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DependencyInjectionPrototype.Shared;
using Unity.Exceptions;

namespace DependencyInjectionPrototype.Mvc
{
    public class IocDependencyResolver : IDependencyResolver
    {
        IInjectionContainer _container;

        public IocDependencyResolver(IInjectionContainer container)
        {
            _container = container;
        }

        public object GetService(Type serviceType)
        {
            if (typeof(IController).IsAssignableFrom(serviceType))
                return _container.Resolve(serviceType);

            try
            {
                return _container.Resolve(serviceType);
            }
            catch (ResolutionFailedException rex)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.ResolveAll(serviceType);
        }
    }
}