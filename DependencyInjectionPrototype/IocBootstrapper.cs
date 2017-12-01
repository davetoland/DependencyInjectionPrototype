using DependencyInjectionPrototype.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DependencyInjectionPrototype
{
    public class IocBootstrapper
    {
        public IUnityContainer GetContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IClass1, Class1>();
            container.RegisterType<IClass2, Class2>();
            container.RegisterType<IClass3, Class3>();

            return container;
        }
    }
}
