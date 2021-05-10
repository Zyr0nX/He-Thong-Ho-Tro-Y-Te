using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using He_thong_ho_tro_y_te.Models.DB;
using He_thong_ho_tro_y_te.Models.DAO;

namespace He_thong_ho_tro_y_te.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session["username"] = null;
            return Redirect("Login");
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            UserDAO dao = new UserDAO();
            if (dao.checkLogin(username, password))
            {
                Session["username"] = username;
                return Redirect("~/Home/Index");

            }
            else return Redirect("Login");
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}