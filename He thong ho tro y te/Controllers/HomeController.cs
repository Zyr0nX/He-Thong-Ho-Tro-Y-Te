﻿using System;
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
        public ActionResult News(string searchString, int PageNum = 1, int PageSize = 5)
        {
            var dao = new NewsDAO();
            var model = dao.ListNewsPage(searchString, PageNum, PageSize);


            ViewBag.SearchString = searchString;



            return View(model);
        }
        public ActionResult ChiTietTinTuc(int id)
        {

            News product = new NewsDAO().Detail(id);

            return View(product);

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
            return View();
        }

        [HttpPost]
        public ActionResult Add(string tenkh, string gioitinh, DateTime ngaysinh, string diachi, string thudientu, string sodienthoai, string khoakham, string giohen, DateTime ngayhen, string ghichu)
        {
            LichHen lh = new LichHen();
            lh.TenKH = tenkh;
            lh.GioiTinh = gioitinh;
            // lh.NgaySinh = DateTime.ParseExact(ngaysinh, "dd/MM/yyyy", null);   
            lh.NgaySinh = ngaysinh;
            lh.DiaChi = diachi;
            lh.ThuDienTu = thudientu;
            lh.SoDienThoai = sodienthoai;
            lh.KhoaKham = khoakham;
            //lh.GioHen = giohen;
            //  lh.NgayHen = DateTime.ParseExact(ngayhen, "dd/MM/yyyy", null);;
            lh.NgayHen = ngayhen;
            lh.GhiChu = ghichu;
            if (ModelState.IsValid)
            {
                LichHenDAO dao = new LichHenDAO();
                dao.Add(lh);
                return RedirectToAction("Contact");
            }
            else
            {
                return View("Contact");
            }
        }

        public ActionResult Test()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}