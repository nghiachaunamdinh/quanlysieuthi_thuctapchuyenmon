using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
    public class PhieuNhapChiTiet
    {
        public string MaPN { get; set; }
        public string MaMH { get; set; }
        public string MaNCC { get; set; }
        public MatHang MatHang { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public PhieuNhap PhieuNhap { get; set; }
    }
}
