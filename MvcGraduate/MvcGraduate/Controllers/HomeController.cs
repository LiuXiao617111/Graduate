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

        #region HttpPost
        [HttpPost]
        public PartialViewResult GetMyArt(int id = 1208203301)
        {
            var res=homeFun.GetArticle(id);
            return PartialView(res);
        }
        [HttpPost]
        public PartialViewResult GetShareArt(int id = 1208203301)
        {
            var res = homeFun.GetShareicle(id);
            return PartialView(res);
        }
        [HttpPost]
        public PartialViewResult GetNotify(int id = 1208203301)
        {
            var res = homeFun.GetNotify(id);
            return PartialView(res);
        }
        [HttpPost]
        public PartialViewResult GetMyImages(int id=120803301)
        {
            var res = homeFun.GetmMyImages(id);
            return PartialView(res);
        }
        [HttpPost]
        public PartialViewResult GetShareImages(int id = 120803301)
        {
            var res = homeFun.GetShareImages(id);
            return PartialView(res);
        }
        [HttpPost]
        public PartialViewResult GetTeacherImages(int id = 120803301)
        {
            var res = homeFun.GetTeacherImages(id);
            return PartialView(res.ToList());
        }
        #endregion
    }
}
