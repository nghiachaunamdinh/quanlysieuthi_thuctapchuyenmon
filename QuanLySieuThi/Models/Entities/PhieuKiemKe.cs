using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
    public class PhieuKiemKe
    {
        public string MaPKK { get; set; }
        public string MaNV { get; set; }
        public DateTime? NgayCapThe { get; set; }

        //public virtual NhanVien NhanVien { get; set; }
        //public virtual ICollection<PhieuKiemKeChiTiet> PhieuKiemKeChiTiets { get; set; }
        public NhanVien NhanVien { get; set; }
        public List<PhieuKiemKeChiTiet> PhieuKiemKeChiTiets { get; set; }
    }
}
