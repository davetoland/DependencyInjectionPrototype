using DependencyInjectionPrototype.Shared;
using System;
using Unity;

namespace DependencyInjectionPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var bootstrapper = new Bootstrapper();
            IInjectionContainer container = bootstrapper.GetContainer();
            var mgr = new GenericManager(container);

            Console.WriteLine(mgr.GetOutput1());
            Console.WriteLine(mgr.GetOutput2());
            Console.WriteLine(mgr.GetOutput3());

            Console.Read();
        }
    }
}
