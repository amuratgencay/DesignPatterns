using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using DesignPattern.WebApp.Controllers;

namespace DesignPattern.WebApp
{
    public class BllUsageAttribute : FilterAttribute, IActionFilter
    {
        public BllUsageAttribute()
        {
        }

        public BllUsageAttribute(Type type)
        {
            Type = type;
        }

        public Type Type { get; set; }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.Controller is AMGControllerBase)
                if (Type != null)
                {
                    var bllType = Assembly.Load("DesignPattern.WebApp.BLL")
                        .GetTypes().FirstOrDefault(x => x.Name.Contains(Type.Name.Remove(0, 1)));

                    ((AMGControllerBase)filterContext.Controller).GetType().GetField("Bll")
                        .SetValue(filterContext.Controller,
                            Activator.CreateInstance(bllType ?? throw new NullReferenceException()));
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
            filters.Add(new BllUsageAttribute());
        }
    }
}