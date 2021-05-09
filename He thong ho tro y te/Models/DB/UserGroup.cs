namespace He_thong_ho_tro_y_te.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserGroup")]
    public partial class UserGroup
    {
        //public UserGroup()
        //{
        //    UserGroups = new HashSet<User>();
        //}
        [StringLength(20)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
