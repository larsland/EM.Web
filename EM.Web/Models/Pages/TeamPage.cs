using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EM.Web.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace EM.Web.Models.Pages
{
    [ContentType(DisplayName = "TeamPage", GUID = "AFE24EF2-6364-4AA1-B3D9-8A45B481E37E", Description = "")]
    public class TeamPage : BasePage
    {
        public virtual string TeamName { get; set; }
        public virtual XhtmlString Information { get; set; }
        public virtual GameBlock MainGame { get; set; }

    }
}