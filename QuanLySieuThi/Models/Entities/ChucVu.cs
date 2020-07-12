using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
    //[Table("ChucVus")]
    public class ChucVu
    {
        public string MaCV { get; set; }
        public string Ten { get; set; }
        //public virtual ICollection<NhanVien> NhanViens { get; set; }
        public List<NhanVien> NhanViens { get; set; }
    }
}
