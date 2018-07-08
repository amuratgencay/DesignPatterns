using System;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using DesignPattern.WebApp.Controllers;
using DesignPattern.WebApp.Interfaces;

namespace DesignPattern.WebApp
{
    public class BLLUsageAttribute : FilterAttribute, IActionFilter
    {
        public string Name { get; set; }

        public BLLUsageAttribute()
        {
            
        }

        public BLLUsageAttribute(string name)
        {
            Name = name;
        }
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
         
            if (filterContext.Controller is AMGControllerBase)
            {
                if (!string.IsNullOrEmpty(Name))
                {
                    var bllType = Assembly.Load("DesignPattern.WebApp.BLL")
                        .GetTypes().FirstOrDefault(x => x.Name.Contains(Name.Remove(0, 1)));

                    ((Controllers.AMGControllerBase) filterContext.Controller).GetType().GetField("Bll")
                        .SetValue(filterContext.Controller, Activator.CreateInstance(bllType ?? throw new NullReferenceException()));
                }
            }

          
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
          
        }
    }
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new BLLUsageAttribute());
            
        }
    }
}
