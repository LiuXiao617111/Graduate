using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGraduate.Models
{
    public class HomeClass
    {
        private DataClassesDataContext db = new DataClassesDataContext();
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
        public IEnumerable<Notify> GetNotify(int id = 1208203301)
        {
            var q = from c in db.Notify_People
                    where c.NotifyPeopleID == id
                    select c.Notify;
            if (!q.Any())
                return null;
            return q;
        }
    }
}