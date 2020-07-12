using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
    public class PhieuXuatChiTiet
    {
        public string MaPX { get; set; }

        public int? SoLuong
        {
            get; set;
        }
        public string MaMH { get; set; }

        //public virtual MatHang MatHang { get; set; }

        //public virtual PhieuXuat PhieuXuat { get; set; }
        public MatHang MatHang { get; set; }
        public PhieuXuat PhieuXuat { get; set; }
    }
}
