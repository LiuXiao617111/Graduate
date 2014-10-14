using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGraduate.Models
{
    public class HomeClass
    {
        private DataClassesDataContext db = new DataClassesDataContext();
        public Students GetStudent(int id)
        {
            var q = from c in db.Students
                    where c.ID == id
                    select c;
            if (!q.Any())
                return null;
            return q.First();
        }
        public int GetNotifyCount(int id)
        {
            var q = from c in db.Notify_People
                where c.NotifyPeopleID == id
                select c;
            return q.ToList().Count;
        }

        public int GetMaterialCount(int id)
        {
            var facultyId = from c in db.Students
                where c.ID == id
                select c.Grade.FacultyID;
            var q = from c in db.SubjectMaterial
                where c.FacultyID == facultyId.First()
                select c;
            return q.ToList().Count;
        }

        //获取文章
        public  IEnumerable<Article> GetArticle(int id)
        {
            var q = from c in db.Article
                    where c.WritingID == id
                    select c;
            if (!q.Any())
                return null;
            return q;
        }
        public IEnumerable<Article> GetShareicle(int id)
        {
            var q = from c in db.Share_Article
                    where c.SharedID == id
                    select c.Article;
            if (!q.Any())
                return null;
            return q;
        }
        public IEnumerable<Notify> GetNotify(int id)
        {
            var q = from c in db.Notify_People
                    where c.NotifyPeopleID == id
                    select c.Notify;
            if (!q.Any())
                return null;
            return q;
        }
        public IEnumerable<string> GetmMyImages(int id)
        {
            var q = from c in db.Images
                where c.OwnerID == id
                select c.ImagePath;
            if (!q.Any())
                return null;
            return q;
        }
        public IEnumerable<string> GetShareImages(int id)
        {
            var q = from c in db.Share_Images
                where c.StudentID == id
                select c.Images.ImagePath;
            if (!q.Any())
                return null;
            return q;
        }
        public IEnumerable<PeopleImage> GetTeacherImages(int id)
        {
            //找到班级
            var grade = from c in db.Students
                where c.ID == id 
                select c.GradeID;
            //找到老师
            var q = from c in db.Grades_Teachers
                where c.GradeID == grade.First()
                select new PeopleImage{ Name=c.Teachers.Name, Duty=c.Teachers.Duty,Picture=c.Teachers.Picture};
            if (!q.Any())
                return null;
            return q;
        }
        public IEnumerable<PeopleImage> GetBanWeiImages(int id)
        {
            //找到班级
            var grade = from c in db.Students
                where c.ID == id
                select c.GradeID;
            //找到班委
            var q = from c in db.Students
                where c.GradeID == grade.First() && c.Duties!=null && c.Duties!=""
                select new PeopleImage {Name = c.Name, Duty = c.Duties, Picture = c.Picture};
            if (!q.Any())
                return null;
            return q;
        }  
    }
}