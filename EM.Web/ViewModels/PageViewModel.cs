using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EM.Web.Models.Pages;
using EPiServer;

namespace EM.Web.ViewModels
{
    public interface IPageViewModel<out T> where T : BasePage
    {
        T CurrentPage { get; }
        //LayoutViewModel Layout { get; set; }
    }

    public class PageViewModel<T> : IPageViewModel<T> where T : BasePage
    {
        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; private set; }
    }

    public static class PageViewModel
    {
        public static IPageViewModel<BasePage> Create(BasePage page)
        {
            var type = typeof(PageViewModel<>).MakeGenericType(page.GetOriginalType());
            return Activator.CreateInstance(type, page) as IPageViewModel<BasePage>;
        }
    }
}