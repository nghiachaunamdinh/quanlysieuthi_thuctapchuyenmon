using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
   // [Table("NhanViens")]
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string Ten { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Phai { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public DateTime? NgayVaoLam { get; set; }
        public double? MucGiam { get; set; }
        public string MaCV { get; set; }
        public string Username { get; set; }
        public string Pwd { get; set; }
        public string Avatar { get; set; }

        public int? Allowed { get; set; }

        public ChucVu ChucVu { get; set; }
        public List<PhieuNhap> PhieuNhaps { get; set; }
        public List<PhieuXuat> PhieuXuats { get; set; }
        public List<PhieuKiemKe> PhieuKiemKes { get; set; }
        public List<HoaDon> HoaDons { get; set; }
    }
}
