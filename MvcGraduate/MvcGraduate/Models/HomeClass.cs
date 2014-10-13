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
            return q;
        }
    }
}