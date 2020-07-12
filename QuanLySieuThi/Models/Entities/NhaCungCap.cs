using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
    //[Table("NhaCungCaps")]
    public class NhaCungCap
    {
        public string MaNCC { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        //public virtual ICollection<PhieuNhapChiTiet> PhieuNhapChiTiets { get; set; }
        public List<PhieuNhapChiTiet> PhieuNhapChiTiets { get; set; }
    }
}
