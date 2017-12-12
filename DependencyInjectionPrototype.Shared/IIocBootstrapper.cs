using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPrototype.Shared
{
    public interface IIocBootstrapper
    {
        IInjectionContainer GetContainer();
    }
}
