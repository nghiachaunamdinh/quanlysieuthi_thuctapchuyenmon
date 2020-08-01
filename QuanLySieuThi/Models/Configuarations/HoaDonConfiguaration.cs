using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Configuarations
{
    public class HoaDonConfiguaration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDons");
            builder.HasKey(x =>  x.MaHD );
            builder.HasOne(p => p.KhachHang).WithMany(b => b.HoaDons).HasForeignKey(p => p.MaKH);
            builder.HasOne(p => p.NhanVien).WithMany(b => b.HoaDons).HasForeignKey(p => p.MaNV);
        }
    }
}
