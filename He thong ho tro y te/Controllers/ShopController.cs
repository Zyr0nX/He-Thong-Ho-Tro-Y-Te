using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using He_thong_ho_tro_y_te.Models.DAO;
using He_thong_ho_tro_y_te.Models.DB;
using System.IO;

namespace He_thong_ho_tro_y_te.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        
        public ActionResult Index(string searchString, int categoryID = 0, int PageNum = 1, int PageSize = 5)
        {
            var dao = new ProductDAO();
            var model = dao.ListProductPage(searchString, PageNum, PageSize);

            ViewBag.SearchString = searchString;

            return View(model);
        }

        public ActionResult Add(int id)
        {
            GioHangHoa gio = (GioHangHoa)Session["cart"];
            if (gio == null)
                gio = new GioHangHoa();
            //truy van tu csdl
            HangHoaBan hangHoa = new HangHoaBan(id, 1);
            gio.addHangHoa(hangHoa);
            Session["cart"] = gio;
            return Redirect(Request.UrlReferrer.ToString());
        }
        public ActionResult ViewCount()
        {
            GioHangHoa gio = (GioHangHoa)Session["cart"];
            if (gio == null)
                ViewBag.count = 0;
            else
                ViewBag.count = gio.getSL();
            return View();
        }
    }
}