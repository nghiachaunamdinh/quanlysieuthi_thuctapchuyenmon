using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.Configuarations
{
    public class PhieuKiemKeConfiguaration : IEntityTypeConfiguration<PhieuKiemKe>
    {
        public void Configure(EntityTypeBuilder<PhieuKiemKe> builder)
        {
            builder.ToTable("PhieuKiemKes");
            builder.HasKey(x => x.MaPKK);
        }
    }
}
