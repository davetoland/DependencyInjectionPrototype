using DependencyInjectionPrototype.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DependencyInjectionPrototype.Tests
{
    public class IocBootstrapper
    {
        public IUnityContainer GetContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IClass1, MockClass1>();
            container.RegisterType<IClass2, MockClass2>();
            container.RegisterType<IClass3, MockClass3>();

            return container;
        }
    }
}
