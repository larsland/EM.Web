using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.DataAnnotations;
using EPiServer.Editor.TinyMCE.Plugins;

namespace EM.Web.Models.Pages
{
    [ContentType(DisplayName = "PlayerPage", GUID = "F91007F9-2665-4CC9-A2E3-1A2397EBC922", Description = "")]
    public class PlayerPage : BasePage
    {
        public virtual string PlayerName { get; set; }

        public virtual int NumGoals { get; set; }

      


    }
}