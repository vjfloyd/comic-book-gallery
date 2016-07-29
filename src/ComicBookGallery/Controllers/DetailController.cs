using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult Index()
        {
            return View();
        }

        public string hola()
        {
            return "hi bitches";
        }


        //MVC ACTION RESULTA TYPES : 1) 
        // 1) Content action
        public ActionResult Detail()
        {
            return Content("hi bitchess");
        }

        public ActionResult get()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return Redirect("/");
            }
            return Content("hi bitchess");
        }
    }
}