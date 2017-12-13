using DependencyInjectionPrototype.Shared;

namespace DependencyInjectionPrototype.Tests
{
    public class UnityBootstrapper : IIocBootstrapper
    {
        public IInjectionContainer GetContainer()
        {
            var container = new UnityInjectionContainer();
            container.Register<IClass1, Class1>();
            container.Register<IClass2, Class2>();
            container.Register<IClass3, Class3>();

            return container;
        }
    }
}