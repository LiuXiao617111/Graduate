﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcGraduate.Models;

namespace MvcGraduate.Controllers
{
    public class StudyController : Controller
    {
        DetailsClass dClass = new DetailsClass();
        private StudyClass sClass = new StudyClass();
        //
        // GET: /Study/

        public ActionResult Index()
        {
            return View();
        }
        #region 详情页面
        public PartialViewResult Details_HomeWork(int id = 1)
        {
            var res = dClass.HomeWork_Details(id);
            return PartialView(res);
        }
        public PartialViewResult Details_Vacation(int id = 1)
        {
            var res = dClass.Vacation_Details(id);
            return PartialView(res);
        }
        #endregion
        #region HttpPost请求
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
        [HttpPost]
        public PartialViewResult GetMyVacation(int id = 1208203301)
        {
            var res = sClass.GetMyVacation(id);
            return PartialView(res);
        }
        #endregion
    }
}
