using DependencyInjectionPrototype.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPrototype.Tests
{
    public class MockClass3 : IClass3
    {
        public string Val = "I am a Mockery of Class3!";

        public string Print3()
        {
            return Val;
        }
    }
}
