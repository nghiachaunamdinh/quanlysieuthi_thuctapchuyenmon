using QuanLySieuThi.Models.EF;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Data
{
    public class DbInitializer
    {
        public static void Initialize(EShopDBContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.MatHangs.Any())
            {
                return;   // DB has been seeded
            }

            var matHangs = new MatHang[]
            {
                new MatHang{MaMH="mh06",Ten="Alexander", MaLH="lh01",MaDVT="dvt01",NgaySanXuat="18/07/1999",SoLuongNhap=34,SoLuongBan=23,GiaBan=24,GiaMua=10, NgayNhap=DateTime.Parse("2019-09-01")},
                new MatHang{MaMH="mh07",Ten="Alonso",MaLH="lh01",MaDVT="dvt01",NgaySanXuat="18/07/1999",SoLuongNhap=34,SoLuongBan=23,GiaBan=24,GiaMua=10,NgayNhap=DateTime.Parse("2017-09-01")},
                new MatHang{MaMH="mh08",Ten="Anand",MaLH="lh01",MaDVT="dvt01",NgaySanXuat="18/07/1999",SoLuongNhap=34,SoLuongBan=23,GiaBan=24,GiaMua=10,NgayNhap=DateTime.Parse("2018-09-01")},
                new MatHang{MaMH="mh09",Ten="Barzdukas",MaLH="lh01",MaDVT="dvt01",NgaySanXuat="18/07/1999",SoLuongNhap=34,SoLuongBan=23,GiaBan=24,GiaMua=10,NgayNhap=DateTime.Parse("2017-09-01")},
                new MatHang{MaMH="mh001",Ten="Li",MaLH="lh01",MaDVT="dvt01",NgaySanXuat="18/07/1999",SoLuongNhap=34,SoLuongBan=23,GiaBan=24,GiaMua=10,NgayNhap=DateTime.Parse("2017-09-01")},
                new MatHang{MaMH="mh011",Ten="Justice",MaLH="lh01",MaDVT="dvt01",NgaySanXuat="18/07/1999",SoLuongNhap=34,SoLuongBan=23,GiaBan=24,GiaMua=10,NgayNhap=DateTime.Parse("2016-09-01")},
                new MatHang{MaMH="mh014",Ten="Norman",MaLH="lh01",MaDVT="dvt01",NgaySanXuat="18/07/1999",SoLuongNhap=34,SoLuongBan=23,GiaBan=24,GiaMua=10,NgayNhap=DateTime.Parse("2018-09-01")},
                new MatHang{MaMH="mh017",Ten="Olivetto",MaLH="lh01",MaDVT="dvt01",NgaySanXuat="18/07/1999",SoLuongNhap=34,SoLuongBan=23,GiaBan=24,GiaMua=10,NgayNhap=DateTime.Parse("2019-09-01")}
            };

            context.MatHangs.AddRange(matHangs);
            context.SaveChanges();

            
        }
    }
}
