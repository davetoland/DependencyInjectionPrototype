using DependencyInjectionPrototype.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPrototype.Tests
{
    public class MockClass2 : IClass2
    {
        public string Val = "I am a Mockery of Class2!";

        public string Print2()
        {
            return Val;
        }
    }
}
