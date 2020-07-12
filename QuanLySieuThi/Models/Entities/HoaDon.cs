using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
   // [Table("HoaDons")]
    public class HoaDon
    {
        
        public string MaHD { get; set; }
        public DateTime? ThoiDiemLap { get; set; }
        public double? TongTienPhaiTra { get; set; }
        public double? MucGiam { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public int? DiemThuong { get; set; }
        //public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        //public virtual KhachHang KhachHang { get; set; }

        //public virtual NhanVien NhanVien { get; set; }
        public NhanVien NhanVien { get; set; }
        public List<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public KhachHang khachHang { get; set; }
    }
}
