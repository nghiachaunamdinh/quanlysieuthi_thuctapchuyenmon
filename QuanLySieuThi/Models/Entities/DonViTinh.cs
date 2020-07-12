using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
    //[Table("DonViTinhs")]
    public class DonViTinh
    {
        public string MaDVT { get; set; }
        public string Ten { get; set; }
        public List<MatHang> MatHangs { get; set; }

    }
}
