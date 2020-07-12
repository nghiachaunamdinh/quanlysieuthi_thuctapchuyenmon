using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Configuarations
{
    public class PhieuXuatConfiguaration : IEntityTypeConfiguration<PhieuXuat>
    {
        public void Configure(EntityTypeBuilder<PhieuXuat> builder)
        {
            builder.ToTable("PhieuXuats");
            builder.HasKey(x => x.MaPX);
        }
    }
}
