using DependencyInjectionPrototype.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPrototype.Tests
{
    public class MockClass1 : IClass1
    {
        public string Val = "I am a Mockery of Class1!";

        public string Print1()
        {
            return Val;
        }
    }
}
