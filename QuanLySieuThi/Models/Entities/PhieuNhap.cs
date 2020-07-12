using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
    public class PhieuNhap
    {
        public string MaPN { get; set; }
        public DateTime? ThoiDiemLap { get; set; }
        public string MaNV { get; set; }
        //public virtual NhanVien NhanVien { get; set; }
        //public virtual ICollection<PhieuNhapChiTiet> PhieuNhapChiTiets { get; set; }
        public NhanVien NhanVien { get; set; }
        public List<PhieuNhapChiTiet> PhieuNhapChiTiets { get; set; }
    }
}
