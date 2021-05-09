namespace He_thong_ho_tro_y_te.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetailBill")]
    public partial class DetailBill
    {
        [Key]
        [StringLength(50)]
        public string IdBill { get; set; }

        public int? IdProduct { get; set; }

        public int? NumberProduct { get; set; }

        [StringLength(50)]
        public string TotalMoney { get; set; }

        public virtual Bill Bill { get; set; }
    }
}
