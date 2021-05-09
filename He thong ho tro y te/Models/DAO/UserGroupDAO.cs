using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using He_thong_ho_tro_y_te.Models.DB;

namespace He_thong_ho_tro_y_te.Models.DAO
{
    public class UserGroupDAO
    {
        YTeDbContext model;
        public UserGroupDAO()
        {
            model = new YTeDbContext();
        }
        public List<UserGroup> ListGroup()
        {
            return model.UserGroups.ToList();
        }
        public UserGroup getById(string id)
        {
            return model.UserGroups.Single(i => i.Id== id);
        }
    }
}