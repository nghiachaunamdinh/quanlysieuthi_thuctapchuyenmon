using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Configuarations
{
    public class PhieuNhapConfiguaration : IEntityTypeConfiguration<PhieuNhap>
    {
        public void Configure(EntityTypeBuilder<PhieuNhap> builder)
        {
            builder.ToTable("PhieuNhaps");
            builder.HasKey(x => x.MaPN);
        }
    }
}
