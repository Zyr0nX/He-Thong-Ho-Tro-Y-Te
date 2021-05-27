using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using He_thong_ho_tro_y_te.Models.DAO;
using He_thong_ho_tro_y_te.Models.DB;

namespace He_thong_ho_tro_y_te.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult News()
        {
        return View();
        }
        public ActionResult Shop()
        {
            return View();
        }
        public ActionResult HeChuyenGia()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Add(string tenkh, string gioitinh, string ngaysinh, string diachi, string thudientu, string sodienthoai, string khoakham, string giohen, string ngayhen, string ghichu)
        {
            LichHen lh = new LichHen();
            lh.TenKH = tenkh;
            lh.GioiTinh = gioitinh;
            lh.NgaySinh = DateTime.ParseExact(ngaysinh, "dd/MM/yyyy", null);   
            lh.DiaChi = diachi;
            lh.ThuDienTu = thudientu;
            lh.SoDienThoai = sodienthoai;
            lh.KhoaKham = khoakham;
            lh.GioHen = giohen;
            lh.NgayHen = DateTime.ParseExact(ngayhen, "dd/MM/yyyy", null);;
            lh.GhiChu = ghichu;
            if (ModelState.IsValid)
            {
                LichHenDAO dao = new LichHenDAO();
                dao.Add(lh);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Test()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}