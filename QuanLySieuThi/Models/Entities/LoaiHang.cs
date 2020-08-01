using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
    //[Table("LoaiHangs")]
    public class LoaiHang
    {
        public string MaLH { get; set; }
        public string Ten { get; set; }
        public string MaCL { get; set; }
       
        public ChungLoai ChungLoai { get; set; }
        public List<MatHang> MatHangs { get; set; }
    }
}
