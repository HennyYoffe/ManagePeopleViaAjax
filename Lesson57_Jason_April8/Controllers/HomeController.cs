using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson57_Jason_April8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetReversed(string text)
        {
            string reverse = "";
            for(int i = text.Length - 1; i >= 0; i--)
            {
                reverse += text[i];
            }


            ToReverse tr = new ToReverse
            {
                Text = reverse,

            };
            return Json(tr, JsonRequestBehavior.AllowGet);
        }
    }
    public class ToReverse
    {
        public string Text { get; set; }
    }
}