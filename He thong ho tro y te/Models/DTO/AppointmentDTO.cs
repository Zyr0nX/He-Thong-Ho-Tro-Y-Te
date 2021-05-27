using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace He_thong_ho_tro_y_te.Models.DTO
{
    public class AppointmentDTO
    {
        public AppointmentDTO()
        {
        }

        public AppointmentDTO(int id, string tenkh, string gioitinh, DateTime? ngaysinh, string diachi, string thudientu, string sodienthoai, string khoakham, string giohen, DateTime? ngayhen, string ghichu, bool? duyet)
        {
            ID=id;
            TenKH=tenkh;
            GioiTinh=gioitinh;
            NgaySinh=ngaysinh;
            DiaChi=diachi;
            ThuDienTu=thudientu;
            SoDienThoai=sodienthoai;
            KhoaKham=khoakham;
            GioHen=giohen;
            NgayHen=ngayhen;
            GhiChu=ghichu;
            DaDuyet=duyet;
        }

        public int ID { get; set; }

        public string TenKH { get; set; }

        public string GioiTinh { get; set; }

        public DateTime? NgaySinh { get; set; }

        public string DiaChi { get; set; }

        public string ThuDienTu { get; set; }

        public string SoDienThoai { get; set; }

        public string KhoaKham { get; set; }

        public string GioHen { get; set; }

        public DateTime? NgayHen { get; set; }

        public string GhiChu { get; set; }

        public bool? DaDuyet { get; set; }
    }
}