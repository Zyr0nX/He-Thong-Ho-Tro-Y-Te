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
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //[HttpPost]
        //public ActionResult LoginAction(User us, string returnUrl)
        //{    
        //    if ("admin".Equals(us.username) && "123456".Equals(us.pwd))
        //    {
        //        ViewBag.ReturnUrl = returnUrl;
        //        Session["username"] = us.username;
        //        return RedirectToAction("Index", "Home");


        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
        //        return RedirectToAction("Login", "User");
        //    }
        //}
    }
}