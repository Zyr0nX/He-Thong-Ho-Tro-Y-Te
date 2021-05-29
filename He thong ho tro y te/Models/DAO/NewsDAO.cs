using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using He_thong_ho_tro_y_te.Models.DB;
using PagedList;

namespace He_thong_ho_tro_y_te.Models.DAO
{
    public class NewsDAO
    {
        YTeDbContext db;
        public NewsDAO()
        {
            db = new YTeDbContext();

        }
        public List<News> ListNews()
        {
            return db.News.ToList();
        }
        public void Add(News ne)
        {
            db.News.Add(ne);
            db.SaveChanges();
        }

        public void Edit(News entity)
        {
            News ne = getById(entity.ID);
            if (ne != null)
            {
               
                ne.Name = entity.Name;
                ne.Detail = entity.Detail;
                ne.Image = entity.Image;
                

                db.SaveChanges();



            }
        }
        public News Detail(int id)
        {
            return db.News.Find(id);

        }
        public void Delete(int id)
        {
            News pro = db.News.Find(id);
            if (pro != null)
            {
                db.News.Remove(pro);
                db.SaveChanges();
            }
        }
        public News getById(int id)
        {
            return db.News.Single(i => i.ID == id);
        }
        public List<News> ListNews(int Pagenum, int Pagesize)
        {
            return db.News.Skip((Pagenum - 1) * Pagesize).Take(Pagesize).ToList();

        }
        public IQueryable<News> News
        {
            get { return db.News; }
        }
        public IEnumerable<News> ListNewsPage(string searchString ,int Pagenum, int Pagesize)
        {
            IQueryable<News> model = db.News;

            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.Name.Contains(searchString) || x.Detail.Contains(searchString));
            }
           
            return model.OrderByDescending(x => x.ID).ToPagedList(Pagenum, Pagesize);
        }



        public List<News> ListNewNews(int top)
        {
            return db.News.OrderByDescending(x => x.CreatedDate).Take(top).ToList();
        }



    }
}
