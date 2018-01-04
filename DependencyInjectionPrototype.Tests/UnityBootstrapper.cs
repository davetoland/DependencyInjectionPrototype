using DependencyInjectionPrototype.Shared;

namespace DependencyInjectionPrototype.Tests
{
    public class UnityBootstrapper : IIocBootstrapper
    {
        public IInjectionContainer GetContainer()
        {
            var container = new UnityInjectionContainer();
            container.Register<IClass1, MockClass1>();
            container.Register<IClass2, MockClass2>();
            container.Register<IClass3, MockClass3>();

            return container;
        }
    }
}