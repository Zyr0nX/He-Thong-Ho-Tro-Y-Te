using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using He_thong_ho_tro_y_te.Models;
namespace He_thong_ho_tro_y_te.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginAction(User us)
        {
            if ("admin".Equals(us.username) && "123456".Equals(us.pwd))
            {
                Session["username"] = us.username;
                return RedirectToAction("Index", "Home");


            }
            else
            {

                return RedirectToAction("Login", "User");
            }
        }
    }
}