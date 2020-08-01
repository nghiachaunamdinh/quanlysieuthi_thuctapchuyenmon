using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
   // [Table("KhachHangs")]
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public DateTime? NgayCapThe { get; set; }
        public string Anh { get; set; }
        public DateTime? NgayMuaGanNhat { get; set; }
        public double? DiemThuong { get; set; }
        //public virtual ICollection<HoaDon> HoaDons { get; set; }
        public List<HoaDon> HoaDons { get; set; }

    }
}
