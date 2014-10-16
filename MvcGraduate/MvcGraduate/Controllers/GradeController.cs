using MvcGraduate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcGraduate.Controllers
{
    public class GradeController : Controller
    {
        HomeClass hClass = new HomeClass();
        //
        // GET: /Grade/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public PartialViewResult GetBanWei(int id)
        {
            var res=hClass.GetBanWei(id);
            ViewBag.Title = "班委成员";
            return PartialView("GetPeopleInfo",res);
        }
        [HttpPost]
        public PartialViewResult GetTeacher(int id)
        {
            var res = hClass.GetTeacher(id);
            ViewBag.Title = "任课老师";
            return PartialView("GetPeopleInfo",res);
        }
        [HttpPost]
        public PartialViewResult GetClassmate(int id)
        {
            var res = hClass.GetClassmate(id);
            ViewBag.Title = "我的同学";
            return PartialView("GetPeopleInfo",res);
        }
        
    }
}
