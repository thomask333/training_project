using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Training_Project.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                return Redirect("/");
            }
            return Content("Hello from the Comic Books Detail Page!");
          
        }
    }
}