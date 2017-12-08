using DependencyInjectionPrototype.Shared;
using Unity;

namespace DependencyInjectionPrototype
{
    public class UnityBootstrapper : IocBootstrapper
    {
        public override InjectionContainer GetContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IClass1, Class1>();
            container.RegisterType<IClass2, Class2>();
            container.RegisterType<IClass3, Class3>();

            return GenerateInjectionContainer(container);
        }
    }
}