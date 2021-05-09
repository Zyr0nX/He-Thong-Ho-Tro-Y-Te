
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using He_thong_ho_tro_y_te.Models.DB;

namespace He_thong_ho_tro_y_te.Models.DAO
{
    public class UserDAO
    {
        YTeDbContext db;
        public UserDAO()
        {
            db = new YTeDbContext();
        }
        //public int Insert(User entity)
        //{
        //    db.Users.Add(entity);
        //    db.SaveChanges();
        //    return entity.ID;
        //}
        public bool checkLogin(string username, string password)
        {
            bool check = false;
            var a = db.Users.Where(y => y.UserName == username && y.Password == password).ToList().Count();
            if (a >= 1) check = true;
            return check;
        }
    }
}