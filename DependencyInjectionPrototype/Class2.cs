using DependencyInjectionPrototype.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPrototype
{
    public class Class2 : IClass2
    {
        public string Print2()
        {
            return "I am concrete class 2";
        }
    }
}
