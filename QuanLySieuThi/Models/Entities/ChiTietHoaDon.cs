using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
  
    public class ChiTietHoaDon
    {
       

        
        public string MaHD { get; set; }

        public int? SoLuong { get; set; }
       
      
        public string MaMH { get; set; }

        //public virtual HoaDon HoaDon { get; set; }

        //public virtual MatHang MatHang { get; set; }
        public MatHang MatHang { get; set; }
        public HoaDon HoaDon { get; set; }
    }
}
