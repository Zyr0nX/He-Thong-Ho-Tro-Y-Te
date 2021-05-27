using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using He_thong_ho_tro_y_te.Models.DB;
using He_thong_ho_tro_y_te.Models.DTO;
using PagedList;

namespace He_thong_ho_tro_y_te.Models.DAO
{
    public class LichHenDAO
    {
        private static YTeDbContext db;

        public LichHenDAO()
        {
            db = new YTeDbContext();
        }

        public void Add(LichHen lh)
        {
            db.LichHens.Add(lh);
            db.SaveChanges();
        }

        public IEnumerable<AppointmentDTO> list(int Pagenum, int Pagesize)
        {
            var lst = from p in db.LichHens
                      select new AppointmentDTO()
                      {
                            ID=p.ID,
                            TenKH=p.TenKH,
                            GioiTinh=p.GioiTinh,
                            NgaySinh=p.NgaySinh,
                            DiaChi=p.DiaChi,
                            ThuDienTu=p.ThuDienTu,
                            SoDienThoai=p.SoDienThoai,
                            KhoaKham=p.KhoaKham,
                            GioHen=p.GioHen,
                            NgayHen=p.NgayHen,
                            GhiChu=p.GhiChu,
                            DaDuyet=p.DaDuyet
                      };
            return lst.OrderByDescending(x=>x.ID).ToPagedList(Pagenum,Pagesize);
        }

        public static void Duyet(int id)
        {
            var duyet = from p in db.LichHens
                        where p.ID==id
                        select p;
            foreach (var item in duyet)
            {
                item.DaDuyet = true;
            }
            db.SaveChanges();
        }
    }
}