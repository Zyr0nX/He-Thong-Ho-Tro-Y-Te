using He_thong_ho_tro_y_te.Models.DAO;
using He_thong_ho_tro_y_te.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace He_thong_ho_tro_y_te.Areas.Admin.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Admin/Appointment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List(int PageNum = 1, int PageSize = 5)
        {
            var model = new LichHenDAO();
            return View(model.list(PageNum, PageSize));
        }

        [HttpGet]
        public ActionResult Duyet(int id)
        {
            LichHenDAO.Duyet(id);
            return RedirectToAction("List");
        }
    }
}