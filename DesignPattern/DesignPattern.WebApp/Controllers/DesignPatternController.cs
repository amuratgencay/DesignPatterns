using System.Web.Mvc;
using DesignPattern.WebApp.Interfaces;

namespace DesignPattern.WebApp.Controllers
{
    public class DesignPatternController : AMGControllerBase
    {
        [BllUsage(typeof(IBllDesignPatterns))]
        public ActionResult CreationalPatterns()
        {
            var bll = (IBllDesignPatterns) Bll;
            var model = bll.GetCreationalDesignPatterns();
            return View(model);
        }

        [BllUsage(typeof(IBllDesignPatterns))]
        public ActionResult StructuralPatterns()
        {
            var bll = (IBllDesignPatterns) Bll;
            var model = bll.GetStructuralDesignPatterns();
            return View(model);
        }

        [BllUsage(typeof(IBllDesignPatterns))]
        public ActionResult BehavioralPatterns()
        {
            var bll = (IBllDesignPatterns) Bll;
            var model = bll.GetBehavioralDesignPatterns();
            return View(model);
        }
    }
}