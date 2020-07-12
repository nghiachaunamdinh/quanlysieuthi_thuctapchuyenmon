using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Configuarations
{
    public class ChucVuConfiguaration : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.ToTable("ChucVus");
            builder.HasKey(x => x.MaCV);
        }
    }
}
