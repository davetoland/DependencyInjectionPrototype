using DependencyInjectionPrototype.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace DependencyInjectionPrototype.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private IClass1 _class1 = null;
        private IClass2 _class2 = null;
        private IClass3 _class3 = null;
        private IClass1 _thing = null;

        public HomeController(IInjectionContainer ioc)
        {
            _class1 = ioc.Resolve<IClass1>();
            _class2 = ioc.Resolve<IClass2>();
            _class3 = ioc.Resolve<IClass3>();
            _thing = ioc.Resolve<IClass1>("thing");
        }

        public ActionResult Index()
        {
            ViewBag.Output1 = _class1.Print1();
            ViewBag.Output2 = _class2.Print2();
            ViewBag.Output3 = _class3.Print3();
            ViewBag.DayOfWeek = _thing.Print1();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class Thing : IClass1
    {
        private DayOfWeek _dow;

        public Thing(DayOfWeek dow)
        {
            _dow = dow;
        }

        public string Print1()
        {
            return _dow.ToString();
        }
    }
}