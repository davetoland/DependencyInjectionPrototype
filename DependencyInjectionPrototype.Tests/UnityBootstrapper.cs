using DependencyInjectionPrototype.Shared;
using System;
using Unity;
using Unity.Registration;

namespace DependencyInjectionPrototype.Tests
{
    public class UnityBootstrapper : IocBootstrapper
    {
        public override InjectionContainer GetContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IClass1, MockClass1>();
            container.RegisterType<IClass2, MockClass2>();
            container.RegisterType<IClass3, MockClass3>();

            return GenerateInjectionContainer(container);
        }
    }
}