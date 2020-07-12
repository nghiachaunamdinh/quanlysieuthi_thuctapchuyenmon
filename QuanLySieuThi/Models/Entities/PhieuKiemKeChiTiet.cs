using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
    public class PhieuKiemKeChiTiet
    {
        public string MaPKK { get; set; }
        public string MaMH { get; set; }
        public int? SLTon { get; set; }

        //public virtual MatHang MatHang { get; set; }
        //public virtual PhieuKiemKe PhieuKiemKe { get; set; }
        public MatHang MatHang { get; set; }
        public PhieuKiemKe PhieuKiemKe { get; set; }
    }
}
