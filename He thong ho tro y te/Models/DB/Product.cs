namespace He_thong_ho_tro_y_te.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        [DisplayName ("Tên sản phẩm")]
        public string Name { get; set; }

        [StringLength(50)]
        public string Code { get; set; }
        [DisplayName("Số lượng")]
        public int? Amount { get; set; }
        [DisplayName("Giá sản phẩm")]
        public decimal? Price { get; set; }

        public int? ImportPrice { get; set; }

        [StringLength(250)]
        [DisplayName("Ảnh sản phẩm")]
        public string Image { get; set; }

        [Column(TypeName = "xml")]
        public string MoreImages { get; set; }

        [Column(TypeName = "ntext")]
        public string Describe { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        public int? CategoryID { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        [StringLength(250)]
        public string MetaTitel { get; set; }

        public DateTime? CreatedTime { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(250)]
        public string MetaKeywords { get; set; }

        [StringLength(250)]
        public string MetaDescriptions { get; set; }

        public int? ViewCount { get; set; }

        public virtual Category Category { get; set; }
    }
}
