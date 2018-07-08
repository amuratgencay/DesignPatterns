using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesignPattern.WebApp.Interfaces;

namespace DesignPattern.WebApp.Controllers
{
    public class CreationalPatternController : AMGControllerBase
    {
        [BllUsage(typeof(IBllFactoryPattern))]
        public ActionResult FactoryPattern()
        {
            var bll = (IBllFactoryPattern)Bll;
            var model = bll.GetShapeTypes();
            return View(model);
        }

        [HttpGet]
        [BllUsage(typeof(IBllFactoryPattern))]
        public ActionResult FactoryCreateImage(int shapeType)
        {
            var bll = (IBllFactoryPattern)Bll;            
            string model = bll.GetShape(shapeType);
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}