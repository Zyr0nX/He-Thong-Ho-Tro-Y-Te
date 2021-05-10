using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace He_thong_ho_tro_y_te.Models.DAO
{
    public class HangHoaBan
    {
        public HangHoaBan(int id, int sl)
        {
            this.id = id;
            this.sl = sl;
        }

        public int sl
        {
            get;
            set;
        }
        public int id
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
        public int price
        {
            get;
            set;
        }
    }
}