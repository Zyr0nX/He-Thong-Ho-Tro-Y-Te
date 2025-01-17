﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace He_thong_ho_tro_y_te.Models.DTO
{
    public class UserDTO
    {
        public int ID { get; set; }

      
        public string UserName { get; set; }

     
        public string Password { get; set; }

        
        public string GroupID { get; set; }

       
        public string Name { get; set; }

        
        public string Address { get; set; }

       
        public string Email { get; set; }

       
        public string Phone { get; set; }

        public bool? Sex { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime? CreatedDate { get; set; }

       
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

      
        public string ModifiedBy { get; set; }

        public bool? Status { get; set; }
    }
}