using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
   // [Table("ChungLoais")]
    public class ChungLoai
    {
        public string MaCL { get; set; }
        public string Ten { get; set; }
        //public virtual ICollection<LoaiHang> LoaiHangs { get; set; }
        public List<LoaiHang> LoaiHangs { get; set; }
    }
}
