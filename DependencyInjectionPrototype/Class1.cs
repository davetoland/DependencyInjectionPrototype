using DependencyInjectionPrototype.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPrototype
{
    public class Class1 : IClass1
    {
        public string Print1()
        {
            return "I am concrete class 1";
        }
    }
}