namespace He_thong_ho_tro_y_te.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichHen")]
    public partial class LichHen
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TenKH { get; set; }

        [StringLength(5)]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string ThuDienTu { get; set; }

        [StringLength(12)]
        public string SoDienThoai { get; set; }

        [StringLength(50)]
        public string KhoaKham { get; set; }

        [StringLength(50)]
        public string GioHen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHen { get; set; }

        [Column(TypeName = "ntext")]
        public string GhiChu { get; set; }

        public bool? DaDuyet { get; set; }
    }
}
