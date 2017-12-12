using DependencyInjectionPrototype.Shared;

namespace DependencyInjectionPrototype
{
    public class Bootstrapper : IocBootstrapper
    {
        public override IInjectionContainer GetContainer()
        {
            var container = new IInjectionContainer();
            container.Register<IClass1, Class1>();
            container.Register<IClass2, Class2>();
            container.Register<IClass3, Class3>();

            return container;
        }
    }
}