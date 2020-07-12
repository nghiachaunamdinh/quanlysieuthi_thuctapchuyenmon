using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Configuarations
{
    public class NhaCungCapConfiguaration : IEntityTypeConfiguration<NhaCungCap>
    {
        public void Configure(EntityTypeBuilder<NhaCungCap> builder)
        {
            builder.ToTable("NhaCungCaps");
            builder.HasKey(x => x.MaNCC);
        }
    }
}
