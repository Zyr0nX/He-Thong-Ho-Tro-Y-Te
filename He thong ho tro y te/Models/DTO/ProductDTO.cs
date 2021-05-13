using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using He_thong_ho_tro_y_te.Models.DB;

namespace He_thong_ho_tro_y_te.Models.DTO
{
    public class ProductDTO
    {
        public ProductDTO()
        {
            GetCategory();
        }
        public ProductDTO(int productID, string nameOfProduct,decimal? price,int? amount, string image, int? categoryOfProductID)
        {
            Id= productID;
            Name = nameOfProduct;
            Price = price;
            Amount = amount;
            Image = image;
            CategoryID = categoryOfProductID;
            GetCategory();
        }


        [DisplayName("Số thứ tự")]
        public int Id { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }
        [DisplayName("Giá sản phẩm")]
        public decimal? Price { get; set; }
        [DisplayName("Số lượng")]
        public int? Amount { get; set; }

        [DisplayName("Miêu tả")]
        public string Describe { get; set; }

        [DisplayName("Ảnh")]
        public string Image { get; set; }
        [DisplayName("Mã sản phẩm")]
        public int? CategoryID { get; set; }
        [DisplayName("Loại sản phẩm")]
        public string category_name { get; set; }

        public void GetCategory()
        {
            if (CategoryID > 0)
            {
                using (YTeDbContext db = new YTeDbContext())
                {
                    this.category_name = db.Categories.Find(this.CategoryID) != null ? db.Categories.Find(this.CategoryID).CategoryName: string.Empty;
                }
            }
        }
    }
}