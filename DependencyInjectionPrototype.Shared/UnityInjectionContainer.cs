using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;
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

        public void Register<TFrom, TTo>(string name = null)
        {
            if (name != null)
                _container.RegisterType(typeof(TFrom), typeof(TTo), name);
            else
                _container.RegisterType(typeof(TFrom), typeof(TTo));
        }

        public void Register<TFrom, TTo>(LifetimeManager lifetimeMgr, string name = null)
        {
            if (name != null)
                _container.RegisterType(typeof(TFrom), typeof(TTo), name, lifetimeMgr);
            else
                _container.RegisterType(typeof(TFrom), typeof(TTo), lifetimeMgr);
        }

        public void Register<TFrom, TTo>(InjectionConstructor ictor, string name = null)
        {
            if (name != null)
                _container.RegisterType(typeof(TFrom), typeof(TTo), name, ictor);
            else
                _container.RegisterType(typeof(TFrom), typeof(TTo), ictor);
        }

        public void Register<TFrom, TTo>(LifetimeManager lifetimeMgr, InjectionConstructor ictor, string name = null)
        {
            if (name != null)
                _container.RegisterType(typeof(TFrom), typeof(TTo), name, lifetimeMgr, ictor);
            else
                _container.RegisterType(typeof(TFrom), typeof(TTo), lifetimeMgr, ictor);
        }

        public T Resolve<T>(string name = null)
        {
            return name != null ?_container.Resolve<T>(name) : _container.Resolve<T>();
        }

        public IEnumerable<T> ResolveAll<T>()
        {
            return _container.ResolveAll<T>();
        }

        public object Resolve(Type type, string name = null)
        {
            return name != null ? _container.Resolve(type, name) : _container.Resolve(type);
        }

        public IEnumerable<object> ResolveAll(Type type)
        {
            return _container.ResolveAll(type);
        }
    }    
}