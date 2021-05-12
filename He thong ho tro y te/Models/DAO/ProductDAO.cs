using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using He_thong_ho_tro_y_te.Models.DB;
using PagedList;
namespace He_thong_ho_tro_y_te.Models.DAO
{
    public class ProductDAO
    {
        YTeDbContext db;
        public ProductDAO()
        {
            db = new YTeDbContext();

        }
        public List<Product> ListProduct()
        {
            return db.Products.ToList();
        }
        public void Add(Product pro)
        {
            db.Products.Add(pro);
            db.SaveChanges();
            
        }
        public void Edit(Product pro)
        {
            Product product = getById(pro.Id);
            if (product != null)
            {
                product.Name = pro.Name;
                product.Code = pro.Code;
                product.Amount = pro.Amount;
                product.Price = pro.Price;
                product.ImportPrice = pro.ImportPrice;
                product.Image = pro.Image;
                product.Describe = pro.Describe;
                product.Detail = pro.Detail;
                product.CategoryID = pro.CategoryID;
                product.Status = pro.Status;
                product.MetaTitel = pro.MetaTitel;
                product.CreatedTime = pro.CreatedTime;
                product.CreatedBy = pro.CreatedBy;
                product.ModifiedBy = pro.ModifiedBy;
                product.ViewCount = pro.ViewCount;
                db.SaveChanges();
                


            }
        }
        public void Delete(int id)
        {
            Product pro = db.Products.Find(id);
            if (pro != null)
            {
                db.Products.Remove(pro);
                db.SaveChanges();
            }
        }
           public Product getById(int id)
            {
                return db.Products.Single(i => i.Id == id);
            }
            public List<Product>ListProduct(int Pagenum, int Pagesize)
            {
                return db.Products.Skip((Pagenum - 1) * Pagesize).Take(Pagesize).ToList();

            }
            public IQueryable<Product> Products
            {
                get { return db.Products;}
            }
        public IEnumerable<Product> ListProductPage(string searchString, /*string searchString2,string searchString3, */ int Pagenum, int Pagesize)
            {
            IQueryable<Product> model = db.Products;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.Name.Contains(searchString) || x.Name.Contains(searchString));
            }
            //if (!string.IsNullOrEmpty(searchString2) || !string.IsNullOrEmpty(searchString3))
            //{
            //    model = model.Where(x => x.Name.Contains(searchString) || x.Name.Contains(searchString));
            //}
            return model.OrderByDescending(x => x.Id).ToPagedList(Pagenum, Pagesize);
        }


        //public  FindById(int id)
        //{

        //    return db.Products.Find(id);

        //}
        public Product Detail(int id)
        {
            return db.Products.Find(id);

        }
        public List<Product> List()
        {
            return db.Products.ToList();
        }
        public List<Product> ListNewProduct(int top)
        {
            return db.Products.OrderByDescending(x => x.CreatedTime).Take(top).ToList();
        }
        //public List<Product> ListFeatureProduct(int top)
        //{
        //    return db.Products.Where(x => x.TopHot != null && x.TopHot > DateTime.Now).OrderByDescending(x => x.CreatedDate).Take(top).ToList();
        //}
        public List<Product> ListRelatedProducts(int productId)
        {
            var product = db.Products.Find(productId);
            return db.Products.Where(x => x.Id != productId && x.CategoryID == product.CategoryID).ToList();
        }


    }
        
    }
