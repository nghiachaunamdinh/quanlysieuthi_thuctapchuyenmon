using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
    //[Table("MatHangs")]
    public class MatHang
    {
        public string MaMH { get; set; }
        public string Ten { get; set; }
        public string MaLH { get; set; }
        public string MaDVT { get; set; }
        public string NgaySanXuat { get; set; }
        public int? SoLuongNhap { get; set; }
        public int? SoLuongBan { get; set; }
        public int? GiaBan { get; set; }

        public int? GiaMua { get; set; }

        public double? VAT { get; set; }
        public string MoTa { get; set; }
        public DateTime? NgayNhap { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string HinhMinhHoa { get; set; }
        public LoaiHang LoaiHang { get; set; }
        public DonViTinh DonViTinh { get; set; }
        public List<PhieuNhapChiTiet> PhieuNhapChiTiets { get; set; }
        public List<PhieuXuatChiTiet> PhieuXuatChiTiets { get; set; }
        public List<PhieuKiemKeChiTiet> PhieuKiemKeChiTiets { get; set; }
        public List<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
