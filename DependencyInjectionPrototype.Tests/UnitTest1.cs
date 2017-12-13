using DependencyInjectionPrototype.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;

namespace DependencyInjectionPrototype.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var bootstrapper = new UnityBootstrapper();
            IInjectionContainer container = bootstrapper.GetContainer();
            var mgr = new GenericManager(container);

            string val1 = mgr.GetOutput1();
            string val2 = mgr.GetOutput2();
            string val3 = mgr.GetOutput3();

            Assert.AreEqual(val1, new MockClass1().Val);
            Assert.AreEqual(val2, new MockClass2().Val);
            Assert.AreEqual(val3, new MockClass3().Val);
        }
    }
}
