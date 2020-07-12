using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Configuarations
{
    public class LoaiHangConfiguaration : IEntityTypeConfiguration<LoaiHang>
    {
        public void Configure(EntityTypeBuilder<LoaiHang> builder)
        {
            builder.ToTable("LoaiHangs");
            builder.HasKey(x => x.MaLH);
        }
    }
}
