using System;
using System.Collections.Generic;

namespace DependencyInjectionPrototype.Shared
{
    public interface IInjectionContainer
    {
        T Resolve<T>(string name = null);
        IEnumerable<T> ResolveAll<T>();

        object Resolve(Type type, string name = null);
        IEnumerable<object> ResolveAll(Type type);
    }
}