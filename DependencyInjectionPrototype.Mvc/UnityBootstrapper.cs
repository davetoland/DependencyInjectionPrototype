using DependencyInjectionPrototype.Mvc.Models;
using DependencyInjectionPrototype.Shared;
using Unity.Lifetime;

namespace DependencyInjectionPrototype
{
    public class UnityBootstrapper : IIocBootstrapper
    {
        public IInjectionContainer GetContainer()
        {
            var hierachicalLifetimeMgr = new HierarchicalLifetimeManager();

            var container = new UnityInjectionContainer();
            container.Register<IClass1, Class1>();
            container.Register<IClass2, Class2>(new TransientLifetimeManager());
            container.Register<IClass3, Class3>(hierachicalLifetimeMgr);

            return container;
        }
    }
}