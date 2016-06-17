using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EM.Web.Models.Pages;
using EM.Web.ViewModels;
using EPiServer;

namespace EM.Web.Controllers
{
    public class TeamPageController : BasePageController<TeamPage>
    {

        

        public ActionResult Index(TeamPage currentPage)
        {
            var repo = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<IContentRepository>();
            var model = new TeamPageViewModel(currentPage)
            {
                Players = repo.GetChildren<PlayerPage>(currentPage.ContentLink)
            };

            return View(model);
        }
    }
}