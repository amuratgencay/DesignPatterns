using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesignPattern.WebApp.Interfaces;


namespace DesignPattern.WebApp.Controllers
{
    public abstract class AMGControllerBase : Controller
    {
        public IBLL Bll;
    }
}