namespace He_thong_ho_tro_y_te.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        [Key]
        [StringLength(50)]
        public string IdPatient { get; set; }
    }
}
