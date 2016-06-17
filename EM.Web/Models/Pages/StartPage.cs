using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EM.Web.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "25A4DBA0-8294-4072-B6E9-5271A98A46AD", Description = "")]
    public class StartPage : BasePage
    {
       
        public virtual string Lead { get; set; }
        public virtual XhtmlString Content { get; set; }
        public virtual ContentArea ContentArea { get; set; }
        
    }
}