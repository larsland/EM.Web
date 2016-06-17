using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EM.Web.Models.Pages
{
    public abstract class BasePage : PageData
    {
        public virtual string MainTitle { get; set; }


    }
}