using EDP.ExceptionHandling;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDP.TestWeb.Filters
{
    public class ExceptionFilter : Attribute, IActionFilter, IExceptionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Herhangi bi action çalıştıktan sonra çalışır
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

            // Herhangi bir action çalışmadan önce çalışır
        }

        public void OnException(ExceptionContext context)
        {
            if (context.Exception is ExceptionBase)
            {
                if (context.Exception is ModelNotValidException)
                {
                    var mnve = (ModelNotValidException)context.Exception;

                    string viewName = context.ActionDescriptor.RouteValues["action"];
                    string controllerName = context.ActionDescriptor.RouteValues["controller"];


                    var result = new ViewResult();

                    foreach (var item in mnve.ValidationMessage)
                    {

                    }
                    var ctrl = context.ActionDescriptor.RouteValues["controller"];

                    context.Result = result;
                }
            }

            //context.Result = new RedirectToActionResult("Index", "Hata",
            //    new { HataMesaji = context.Exception.Message });
            // Herhangi bir action da hata alındığında çalışır
        }
    }
}
