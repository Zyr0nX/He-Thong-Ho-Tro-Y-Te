using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using He_thong_ho_tro_y_te.Models.DB;
using PagedList;

namespace He_thong_ho_tro_y_te.Models.DAO
{
    public class UserDAO
    {
        YTeDbContext db;
        public UserDAO()
        {
            db = new YTeDbContext();
        }
        
        public bool checkLogin(string username, string password)
        {
            bool check = false;
            var a = db.Users.Where(y => y.UserName == username && y.Password == password).ToList().Count();
            if (a >= 1) check = true;
            return check;
        }
        public int checkLoginHome(string username,string password)
        {

           
            var a = db.Users.SingleOrDefault(y => y.UserName == username && y.Password == password);
            if (a == null) return 0;
            else
            {
                if (a.GroupID == "ADMIN") return 1;
                else if (a.GroupID == "DOCTOR") return 2;
                else return 0;
            }
            

        }

        public void Delete(int id)
        {
            User pro = db.Users.Find(id);
            if (pro != null)
            {
                db.Users.Remove(pro);
                db.SaveChanges();
            }

        }
        
        public void Add(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
        public List<User> ListUser()
        {
            return db.Users.ToList();
        }
        public List<User> List()
        {
            return db.Users.ToList();
        }
        public void Edit(User entity)
        {
            User user = getById(entity.ID);
            if (user != null)
            {
                user.UserName = entity.UserName;
                user.Password = entity.Password;
                user.Name = entity.Name;
                user.DateOfBirth = entity.DateOfBirth;
                user.Address = entity.Address;
                user.Phone = entity.Phone;
                user.Sex = entity.Sex;
                user.GroupID= entity.GroupID;
                user.ModifiedBy = entity.ModifiedBy;
                
                db.SaveChanges();



            }

        }

        public User getById(int id)
        {
            return db.Users.Single(i => i.ID == id);
        }

        public List<User> ListUser(int Pagenum, int Pagesize)
        {
            return db.Users.Skip((Pagenum - 1) * Pagesize).Take(Pagesize).ToList();

        }
        public IQueryable<User> Users
        {
            get { return db.Users; }
        }
        public IEnumerable<User> ListUserPage(string searchString, int Pagenum, int Pagesize)
        {
            IQueryable<User> model = db.Users;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(a => a.Name.Contains(searchString));
            }
            return db.Users.OrderByDescending(a => a.GroupID).ToPagedList(Pagenum, Pagesize);
        }


        
        public User Detail(int id)
        {
            return db.Users.Find(id);

        }



    
}
}