using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Configuarations
{
    public class ChungLoaiConfiguaration : IEntityTypeConfiguration<ChungLoai>
    {
        public void Configure(EntityTypeBuilder<ChungLoai> builder)
        {
            builder.ToTable("ChungLoais");
            builder.HasKey(x => x.MaCL);
        }
    }
}
