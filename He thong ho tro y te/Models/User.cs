using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace He_thong_ho_tro_y_te.Models
{
    public class User
    {
            [Required(ErrorMessage ="Bạn cần nhập tên đăng nhập")] 
            public string username { get; set; }
            [Required(ErrorMessage = "Bạn cần nhập mật khẩu")]
             public string pwd { get; set; }
            public bool RememberMe { get; set; }
    }
}