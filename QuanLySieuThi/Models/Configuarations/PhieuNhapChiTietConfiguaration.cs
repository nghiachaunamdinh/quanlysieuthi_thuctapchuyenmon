using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Configuarations
{
    public class PhieuNhapChiTietConfiguaration : IEntityTypeConfiguration<PhieuNhapChiTiet>
    {
        public void Configure(EntityTypeBuilder<PhieuNhapChiTiet> builder)
        {
            builder.ToTable("PhieuNhapChiTiets");
            builder.HasKey(x => x.MaPN);
        }
    }
}
