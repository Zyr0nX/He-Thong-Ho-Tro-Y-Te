using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using He_thong_ho_tro_y_te.Models;


namespace He_thong_ho_tro_y_te.Controllers
{
    public class HeChuyenGiaController : Controller
    {
        public int lamsang=0;
        // GET: HeChuyenGia
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CSTT1()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult CSTT1(string dauvao)
         {
            
            
            if (dauvao=="dau_vao1")
            {
                ViewBag.Dauvao1 = "checked";
                ViewBag.Dauvao0 = "";
                return RedirectToAction("CSTT2");
                
            }
            else if(dauvao=="dau_vao0")
            {
               
                ViewBag.Dauvao1 = "";
                ViewBag.Dauvao0 = "checked";
                return Redirect("KhongBiGout");
            }

            else
            {   
                return View();
            }

        }
        public ActionResult CSTT2()
        {
           
            return View();
         }
        [HttpPost]
        public ActionResult CSTT2(string vang)
        {
            if (vang == "vang0")
            {
              //  ViewBag.vang1 = "";
             //   ViewBag.vang0 = "checked";
                return RedirectToAction("CSTT3");
                
            }


            else if (vang == "vang1")
            {

                ViewBag.vang1 = "checked";
                ViewBag.vang0 = "";
                return Redirect("BiGout");
            }
            else return View();
         }

          public ActionResult CSTT3()
          {
            return View();
          }
       
        [HttpPost]
        public ActionResult CSTT3(string a1, string a2, string a3,string a4,string a5,string a6,string a7,string a8)
        {   lamsang =0;
            if (a1 == "a1") lamsang = lamsang + 1;
            if (a2 == "a2") lamsang = lamsang + 2;
            if (a3 == "a3") lamsang = lamsang + 1;
            if (a4 == "a4") lamsang = lamsang + 1;
            if (a5 == "a5") lamsang = lamsang + 1;
            if (a6 == "a6") lamsang = lamsang + 1;
            if (a7 == "a7") lamsang = lamsang + 2;
            if (a8 == "a8") lamsang = lamsang + 4;

            Session["lamsang"] = lamsang;
            if (lamsang >= 8)
            {
                return Redirect("BiGout");
            }
            else if (lamsang < 8)
            {
                return Redirect("CSTT4");
            }
            else
            return View();
        }
        public ActionResult CSTT4()
        {
            int abc = Convert.ToInt32(Session["lamsang"]);
            ViewBag.lamsa = abc;
            return View();
        }
        [HttpPost]
        public ActionResult CSTT4(string axit,string xn,string ha1,string ha2,string xquang)
        {
            
            
             
            ViewBag.lamsa2 = lamsang;
            int canlamsang = lamsang;
            if (axit == "axit")
            {
                if (axit == "axit1")  canlamsang = (canlamsang - 4);
                if (axit == "axit2") canlamsang = canlamsang+0 ;
                if (axit == "axit3") canlamsang = (canlamsang +2);
                if (axit == "axit4") canlamsang = (canlamsang +3);
                if (axit == "axit5") canlamsang = (canlamsang +4);
            }
            if (xn == "xn") canlamsang = canlamsang - 2;
            if (ha1 == "ha1") canlamsang = canlamsang +4;
            if (ha2 == "ha2") canlamsang = canlamsang +4;
            if (xquang == "xquang") canlamsang = canlamsang +4;
           
            if (canlamsang>= 8)
            {
                return Redirect("BiGout");
            }
            else if (canlamsang < 4)
            {
                return Redirect("KhongBiGout");
            }
            else if(canlamsang>=4 && canlamsang <= 5)
            {
                return Redirect("NguyCo");
            }
            else if (canlamsang >= 4 && canlamsang <= 5)
            {
                return Redirect("NguyCoCao");
            }

            return View();
        }
        public ActionResult BiGout()
        {
            return View();
        }
        public ActionResult KhongBiGout()
        {
            return View();
        }
        public ActionResult NguyCo()
        {
            return View();
        }
        public ActionResult NguyCoCao()
        {
            return View();
        }
    }
}