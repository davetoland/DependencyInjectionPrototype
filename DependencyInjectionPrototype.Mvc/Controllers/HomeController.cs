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

        public HomeController(IInjectionContainer ioc)
        {
            _class1 = ioc.Resolve<IClass1>();
            _class2 = ioc.Resolve<IClass2>();
            _class3 = ioc.Resolve<IClass3>();
        }

        public ActionResult Index()
        {
            ViewBag.Output1 = _class1.Print1();
            ViewBag.Output2 = _class2.Print2();
            ViewBag.Output3 = _class3.Print3();

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
}