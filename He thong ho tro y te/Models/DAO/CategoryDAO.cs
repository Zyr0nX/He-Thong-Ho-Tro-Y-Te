using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using He_thong_ho_tro_y_te.Models.DB;

namespace He_thong_ho_tro_y_te.Models.DAO
{
    public class CategoryDAO
    {
        YTeDbContext model;
        public CategoryDAO()
        {
            model = new YTeDbContext();
        }
        public List<Category> ListCate()
        {
            return model.Categories.ToList();
        }
        public Category getById(int id)
        {
            return model.Categories.Single(i => i.CategoryID == id);
        }
    }
}