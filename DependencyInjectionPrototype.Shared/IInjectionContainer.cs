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
    public interface IInjectionContainer
    {
        T Resolve<T>();
        IEnumerable<T> ResolveAll<T>();

        object Resolve(Type type);
        IEnumerable<object> ResolveAll(Type type);
    }
}