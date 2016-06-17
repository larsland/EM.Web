using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EM.Web.Models.Pages;

namespace EM.Web.ViewModels
{
    public class TeamPageViewModel : PageViewModel<TeamPage>
    {
        public IEnumerable<PlayerPage> Players { get; set; }
        public TeamPageViewModel(TeamPage currentPage) : base(currentPage)
        {
            
        }

    }
}