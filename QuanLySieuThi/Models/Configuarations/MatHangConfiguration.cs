using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Configuarations
{
    public class MatHangConfiguration : IEntityTypeConfiguration<MatHang>
    {
        public void Configure(EntityTypeBuilder<MatHang> builder)
        {
            builder.ToTable("MatHangs");
            builder.HasKey(x =>x.MaMH);
            builder.HasOne(p => p.DonViTinh).WithMany(b => b.MatHangs).HasForeignKey(p => p.MaDVT);
            builder.HasOne(p => p.LoaiHang).WithMany(b => b.MatHangs).HasForeignKey(p => p.MaLH);
        }
    }
}
