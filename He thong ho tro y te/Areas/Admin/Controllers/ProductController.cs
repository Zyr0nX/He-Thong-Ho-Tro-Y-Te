using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using He_thong_ho_tro_y_te.Models.DAO;
using He_thong_ho_tro_y_te.Models.DB;
using System.IO;


namespace He_thong_ho_tro_y_te.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        
        // GET: QLSanPham
        public ActionResult Delete(int id)
        {
            ProductDAO dao = new ProductDAO();
            dao.Delete(id);
            return Redirect("~/Admin/Product/Index");
        }
        public ActionResult Detail(int id)
        {
            var product = new ProductDAO().Detail(id);
            
            return View(product);
        }

        public ActionResult Add()
        {
            List<Category> ls = new List<Category>();
            CategoryDAO dao = new CategoryDAO();
            return View(dao.ListCate());
        }
        public ActionResult Edit(int id)
        {
            List<Category> ls = new List<Category>();
            CategoryDAO dao = new CategoryDAO();
            ProductDAO proDao = new ProductDAO();
            ViewBag.cat = dao.ListCate();
            ViewBag.pro = proDao.getById(id);
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, string idcategory, string describe, string name, string amount, string price, HttpPostedFileBase image)
        {
            var img = Path.GetFileName(image.FileName);
            ProductDAO dao = new ProductDAO();
            Product product = dao.getById(id);
            product.Amount = Int32.Parse(amount);
            product.Price = Int32.Parse(price);
            product.Name = name;
            product.Describe = describe;
            product.CategoryID = Int32.Parse(idcategory);
            if (ModelState.IsValid)
            {
                if (image != null && image.ContentLength > 0)
                {
                    var path = Path.Combine(Server.MapPath("~/Asset/Photo/"),
                                            System.IO.Path.GetFileName(image.FileName));
                    image.SaveAs(path);

                    product.Image = image.FileName;
                    dao.Add(product);
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }

        [HttpPost]
        public ActionResult Add(string idcategory, string describe, string name, string amount, string price, HttpPostedFileBase image)
        {
            var img = Path.GetFileName(image.FileName);
            Product product = new Product();
            product.Amount = Int32.Parse(amount);
            product.Price = Int32.Parse(price);
            product.Name = name;
            product.Describe = describe;
            product.CategoryID = Int32.Parse(idcategory);
            if (ModelState.IsValid)
            {
                if (image != null && image.ContentLength > 0)
                {
                    var path = Path.Combine(Server.MapPath("~/Asset/Photo/"),
                                            System.IO.Path.GetFileName(image.FileName));
                    image.SaveAs(path);

                    product.Image = image.FileName;
                    ProductDAO dao = new ProductDAO();
                    dao.Add(product);
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }


        //public ActionResult Index(string searchString, int PageNum = 1, int PageSize = 2)
        //{
        //    var dao = new ProductDAO();
        //  var model = dao.ListProductPage(searchString, PageNum, PageSize);
        //   ViewBag.SearchString = searchString;
        //   return View(model);
        //}


        public ActionResult Index(string searchString,/*string searchString2, string searchString3,*/ int categoryID = 0, int PageNum = 1, int PageSize = 5)
        {
            var dao = new ProductDAO();
           var model = dao.ListProductPage(searchString,/*searchString2,searchString3,*/ PageNum, PageSize);

           ViewBag.SearchString = searchString;
           //ViewBag.SearchString2 = searchString;
           //ViewBag.SearchString3 = searchString;

            return View(model);
        }
        //public ActionResult Index(string searchString, int categoryID = 0)
        //{
            
            
        //    //1. Tạo danh sách danh mục để hiển thị ở giao diện View thông qua DropDownList
        //    var categories = from c in db.Categories select c;
        //    ViewBag.categoryID = new SelectList(categories, "Id", "Name"); // danh sách Category

        //    //2. Tạo câu truy vấn kết 2 bảng Link, Category bằng mệnh đề join
        //    var links = from l in db.Products
        //                join c in db.Categories on l.CategoryID equals c.CategoryID
        //                select new { l.Id,l.Name,l.Category,  l.Price, l.CategoryID, c.CategoryName};

        //    //3. Tìm kiếm chuỗi truy vấn
        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        links = links.Where(s => s.Name.Contains(searchString));
        //    }

        //    //4. Tìm kiếm theo CategoryID
        //    if (categoryID != 0)
        //    {
        //        links = links.Where(x => x.CategoryID== categoryID);
        //    }

        //    //5. Chuyển đổi kết quả từ var sang danh sách List<Link>
        //    List<Product> listLinks = new List<Product>();
        //    foreach (var item in links)
        //    {
        //        Product temp = new Product();
        //        temp.CategoryID = item.CategoryID;
        //        temp.Name = item.Name;
        //        temp.Id = item.Id;
                
        //        listLinks.Add(temp);
        //    }

        //    return View(listLinks);
        //}


    }
}
