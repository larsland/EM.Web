using System.Web.Mvc;
using EM.Web.Models.Pages;
using EM.Web.ViewModels;
using EPiServer;

namespace EM.Web.Controllers

{
   // [TemplateDescription(Inherited=true, TemplateTypeCategory = TemplateTypeCategories.MvcController )]
    public class DefaultPageController : BasePageController<BasePage>
    {
        // GET: DefaultPage
        public ActionResult Index(BasePage currentPage)
        {
            var pageType = currentPage.GetOriginalType().Name;
            var viewPath = $"~/Views/{pageType}/Index.cshtml";
            var viewModel = PageViewModel.Create(currentPage);


            return View(viewPath, viewModel);
        }
    }
}