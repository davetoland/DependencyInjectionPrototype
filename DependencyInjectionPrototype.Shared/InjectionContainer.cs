using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Registration;

namespace DependencyInjectionPrototype.Shared
{
    public class InjectionContainer
    {
        private Dictionary<Type, object> _registrations;

        public InjectionContainer()
        {
            _registrations = new Dictionary<Type, object>();
        }

        public void Add(Type t, object o)
        { 
            if (t != typeof(IUnityContainer))
                _registrations.Add(t, o);
        }

        public T Get<T>()
        {
            object o = _registrations.SingleOrDefault(x => x.Key == typeof(T)).Value;
            if (o != null)
                return (T)o;
            else
                return default(T);
        }
    }
}
