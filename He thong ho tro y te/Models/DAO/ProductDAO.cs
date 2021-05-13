using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using He_thong_ho_tro_y_te.Models.DB;
using PagedList;
using He_thong_ho_tro_y_te.Models.DTO;
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
        public Product Detail(int id)
        {
            return db.Products.Find(id);

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
        public IEnumerable<Product> ListProductPage(string searchString, string searchString2,string searchString3,string searchCat,  int Pagenum, int Pagesize)
            {
            IQueryable<Product> model = db.Products;

            if (!string.IsNullOrEmpty(searchString))
            {   
                model = model.Where(x => x.Name.Contains(searchString) || x.Price.ToString().Contains(searchString) );
            }
            else if (!string.IsNullOrEmpty(searchString2) && !string.IsNullOrEmpty(searchString3))
            {
                int tu = Int32.Parse(searchString2);
                int mau= Int32.Parse(searchString3);
               model = model.Where(x => x.Amount>= tu || x.Amount<=mau);
                
            }
            else if (!string.IsNullOrEmpty(searchCat))
            {
                model = model.Where(x => x.Name.Contains(searchCat));


            }
            return model.OrderByDescending(x => x.Id).ToPagedList(Pagenum, Pagesize);
        }
        public IEnumerable<ProductDTO> lstjoin(string searchString, string searchString2, string searchString3, string searchCat,  int Pagenum, int Pagesize)
        {
            //var lst = db.Database.SqlQuery<ProductDTO>("select " +
            //    "pro.Id as id, " +
            //    "pro.Name as name, " +
            //    "pro.Price as price, " +
            //    "pro.Amount as amount, " +
            //    "pro.Describe as description, " +
            //    "pro.image as photo, " +
            //    "pro.Categoryid as idcategory, " +
            //    "c.CategoryName as category_name " +
            //    "from Product pro left join Category c on pro.CategoryID = c.CategoryID"
            //    );
            var lst = from p in db.Products
                      join c in db.Categories on p.CategoryID equals c.CategoryID
                      select new ProductDTO()
                      {
                          Id = p.Id,
                          Name = p.Name,
                          Price = p.Price,
                          Amount = p.Amount,
                          Describe=p.Describe,
                          Image =p.Image,
                          CategoryID =p.CategoryID,
                          category_name=c.CategoryName
                      };
           
           if (!string.IsNullOrEmpty(searchString))
            {
                lst = lst.Where(x => x.Name.Contains(searchString) || x.Price.ToString().Contains(searchString));
                
            }
            else if (!string.IsNullOrEmpty(searchString2) && !string.IsNullOrEmpty(searchString3))
            {
              int tu = Int32.Parse(searchString2);
               int den = Int32.Parse(searchString3);
                lst = lst.Where(x => x.Price >= tu && x.Price <= den);


            }
            else if (!string.IsNullOrEmpty(searchCat))
            {
               lst = lst.Where(x => x.category_name.Contains(searchCat));

            }

             return lst.OrderByDescending(x=>x.Id).ToPagedList(Pagenum,Pagesize);
           
            
        }


        //public  FindById(int id)
        //{

        //   return db.Products.Find(id);

        //}
        
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
