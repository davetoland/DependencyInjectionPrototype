using DependencyInjectionPrototype.Shared;
using Unity;

namespace DependencyInjectionPrototype
{
    //This is the class under test
    public class GenericManager
    {
        private IClass1 _class1 = null;
        private IClass2 _class2 = null;
        private IClass3 _class3 = null;

        public GenericManager(IInjectionContainer ioc)
        {
            _class1 = ioc.Get<IClass1>();
            _class2 = ioc.Get<IClass2>();
            _class3 = ioc.Get<IClass3>();
        }

        public string GetOutput1()
        {
            return _class1.Print1();
        }

        public string GetOutput2()
        {
            return _class2.Print2();
        }
        public string GetOutput3()
        {
            return _class3.Print3();
        }
    }
}
