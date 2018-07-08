using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesignPattern.WebApp.Entity;
using DesignPattern.WebApp.Interfaces;

namespace DesignPattern.WebApp.Controllers
{
    public class DesignPatternController : AMGControllerBase
    {
        [BLLUsage("IBLLDesignPatterns")]
        public ActionResult CreationalPatterns()
        {
            IBLLDesignPatterns bll = (IBLLDesignPatterns)Bll;
            vmCreationalDesignPatterns model = bll.GetCreationalDesignPatterns();
            return View(model);
        }

        [BLLUsage("IBLLDesignPatterns")]
        public ActionResult StructuralPatterns()
        {
            IBLLDesignPatterns bll = (IBLLDesignPatterns)Bll;
            vmStructuralDesignPatterns model = bll.GetStructuralDesignPatterns();
            return View(model);
        }

        [BLLUsage("IBLLDesignPatterns")]
        public ActionResult BehavioralPatterns()
        {
            IBLLDesignPatterns bll = (IBLLDesignPatterns)Bll;
            vmBehavioralDesignPatterns model = bll.GetBehavioralDesignPatterns();
            return View(model);
        }
    }
}