using System.Web.Mvc;
using DesignPattern.WebApp.Interfaces;

namespace DesignPattern.WebApp.Controllers
{
    public abstract class AMGControllerBase : Controller
    {
        public IBll Bll;
    }
}