using System.Collections.Generic;
using CommonsNET8.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommonsNET8.ViewComponents
{
    public class BreadcrumbViewComponent : ViewComponent
    {

        public BreadcrumbViewComponent()
        {
            
        }

        public IViewComponentResult Invoke(string filter)
        {
            if (ViewBag.Breadcrumb == null)
            {
                ViewBag.Breadcrumb = new List<Message>();
            }
            
            return View("LayoutBreadcrumb", ViewBag.Breadcrumb as List<Message>);
        }
    }
}
