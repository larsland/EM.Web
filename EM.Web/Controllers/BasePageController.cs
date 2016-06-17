using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EM.Web.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace EM.Web.Controllers
{
    public class BasePageController<T> : PageController<T> where T:PageData
    {
        public ViewResult FallbackView(string viewName, string fallbackViewName, object model)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            var viewResult = ViewEngineCollection.FindView(this.ControllerContext, viewName, null);
            return View(viewResult.View != null ? viewName : fallbackViewName, model);
        }
    }
}