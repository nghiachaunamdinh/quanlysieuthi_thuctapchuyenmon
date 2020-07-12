using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Configuarations
{
    public class PhieuKiemKeChiTietConfiguaration : IEntityTypeConfiguration<PhieuKiemKeChiTiet>
    {
        public void Configure(EntityTypeBuilder<PhieuKiemKeChiTiet> builder)
        {
            builder.ToTable("PhieuKiemKeChiTiets");
            builder.HasKey(x => x.MaPKK);
        }
    }
}
