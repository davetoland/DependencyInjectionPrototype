using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;
using Unity.Registration;

namespace DependencyInjectionPrototype.Shared
{
    public class UnityInjectionContainer : IInjectionContainer
    {
        private IUnityContainer _container;

        public UnityInjectionContainer()
        {
            _container = new UnityContainer();
            _container.RegisterInstance<IInjectionContainer>(this);
        }

        public void Register<TFrom, TTo>(LifetimeManager lifetimeMgr = null)
        {
            if (lifetimeMgr != null)
                _container.RegisterType(typeof(TFrom), typeof(TTo), lifetimeMgr);
            else
                _container.RegisterType(typeof(TFrom), typeof(TTo));
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public IEnumerable<T> ResolveAll<T>()
        {
            return _container.ResolveAll<T>();
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

        public IEnumerable<object> ResolveAll(Type type)
        {
            return _container.ResolveAll(type);
        }
    }    
}