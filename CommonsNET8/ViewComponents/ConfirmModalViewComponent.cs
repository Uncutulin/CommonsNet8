using System;
using System.Collections.Generic;
using System.Text;
using CommonsNET8.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommonsNET8.ViewComponents
{
    public class ConfirmModalViewComponent : ViewComponent
    {
        public ConfirmModalViewComponent()
        {

        }

        public IViewComponentResult Invoke()
        {
            return View("ConfirmModal");
        }
    }
}
