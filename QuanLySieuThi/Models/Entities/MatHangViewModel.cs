using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Entities
{
    public class MatHangViewModel
    {
        public IQueryable<MatHang> sMatHang { get; set; }
        public string Text { get; set; }
    }
}
