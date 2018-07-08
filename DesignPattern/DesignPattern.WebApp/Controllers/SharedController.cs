using System.Web.Mvc;
using DesignPattern.WebApp.Interfaces;

namespace DesignPattern.WebApp.Controllers
{
    public class SharedController : AMGControllerBase
    {
        [BllUsage(typeof(IBllDesignPatterns))]
        public ActionResult Menu()
        {
            var bll = (IBllDesignPatterns) Bll;
            var model = bll.GetDesignPatterns();
            return PartialView(model);
        }
    }
}