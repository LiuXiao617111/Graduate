using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcGraduate.Models;

namespace MvcGraduate.Controllers
{
    public class HomeController : Controller
    {
        private HomeClass homeFun = new HomeClass();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult GetMyArt(int id = 1208203301)
        {
            var res=homeFun.GetArticle(id);
            return PartialView(res);
        }
    }
}
