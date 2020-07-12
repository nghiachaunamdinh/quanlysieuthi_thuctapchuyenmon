using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
    public class PhieuXuat
    {
        public string MaPX { get; set; }
        public DateTime? ThoiDiemLap { get; set; }
        public string MaNV { get; set; }
        //public virtual NhanVien NhanVien { get; set; }
        //public virtual ICollection<PhieuXuatChiTiet> PhieuXuatChiTiets { get; set; }
        public NhanVien NhanVien { get; set; }
        public List<PhieuXuatChiTiet> PhieuXuatChiTiets { get; set; }
    }
}
