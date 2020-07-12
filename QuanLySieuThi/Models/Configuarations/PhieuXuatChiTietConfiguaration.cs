using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Configuarations
{
    public class PhieuXuatChiTietConfiguaration : IEntityTypeConfiguration<PhieuXuatChiTiet>
    {
        public void Configure(EntityTypeBuilder<PhieuXuatChiTiet> builder)
        {
            builder.ToTable("PhieuXuatChiTiets");
            builder.HasKey(x => x.MaPX);
        }
    }
}
