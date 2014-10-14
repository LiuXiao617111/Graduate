using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcGraduate.Models;

namespace MvcGraduate.Controllers
{
    public class StudyController : Controller
    {
        private StudyClass sClass = new StudyClass();
        //
        // GET: /Study/

        public ActionResult Index()
        {
            return View();
        }

        #region HttpPost
        [HttpPost]
        public PartialViewResult GetHomeWork(int id = 1208203301)
        {
            var res=sClass.GetHomeWork(id);
            return PartialView(res);
        }
        [HttpPost]
        public PartialViewResult GetTimeTable(int id = 1208203301)
        {
            var res = sClass.GetTimeTable(id);
            return PartialView(res);
        }

        #endregion
    }
}
