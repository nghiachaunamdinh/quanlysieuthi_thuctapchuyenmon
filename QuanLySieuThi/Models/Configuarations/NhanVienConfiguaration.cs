using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Configuarations
{
    public class NhanVienConfiguaration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanViens");
            builder.HasKey(x => x.MaNV);
            builder.HasOne(p => p.ChucVu).WithMany(b => b.NhanViens).HasForeignKey(p => p.MaCV);
        }
    }
}
