using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Configuarations
{
    public class DonViTinhConfiguaration : IEntityTypeConfiguration<DonViTinh>
    {
        public void Configure(EntityTypeBuilder<DonViTinh> builder)
        {
            builder.ToTable("DonViTinhs");
            builder.HasKey(x => x.MaDVT);
        }
    }
}
