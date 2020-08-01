using Microsoft.EntityFrameworkCore;
using QuanLySieuThi.Models.Configuarations;
using QuanLySieuThi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models.EF
{
    public class EShopDBContext : DbContext
    {
        public EShopDBContext( DbContextOptions options) : base(options)
        {
            
        }
        
        public DbSet<MatHang> MatHangs { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<ChungLoai> ChungLoais { get; set; }
        public DbSet<DonViTinh> DonViTinhs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }

        public DbSet<LoaiHang> LoaiHangs { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhieuKiemKe> PhieuKiemKes { get; set; }
        public DbSet<PhieuKiemKeChiTiet> PhieuKiemKeChiTiets { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public DbSet<PhieuNhapChiTiet> PhieuNhapChiTiets { get; set; }
        public DbSet<PhieuXuat> PhieuXuats { get; set; }
        public DbSet<PhieuXuatChiTiet> PhieuXuatChiTiets { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiHang>()
                  .HasMany(c => c.MatHangs)
                  .WithOne(e => e.LoaiHang);
            modelBuilder.Entity<ChungLoai>()
                  .HasMany(c => c.LoaiHangs)
                  .WithOne(e => e.ChungLoai);
            modelBuilder.Entity<DonViTinh>()
                   .HasMany(c => c.MatHangs)
                    .WithOne(e => e.DonViTinh);
            modelBuilder.Entity<HoaDon>()
               .HasMany(e => e.ChiTietHoaDons)
               .WithOne(e => e.HoaDon);
            modelBuilder.Entity<KhachHang>()
              .HasMany(e => e.HoaDons)
              .WithOne(e => e.KhachHang);

            modelBuilder.Entity<NhaCungCap>()
              .HasMany(e => e.PhieuNhapChiTiets)
              .WithOne(e => e.NhaCungCap);

            modelBuilder.Entity<PhieuNhap>()
              .HasMany(e => e.PhieuNhapChiTiets)
              .WithOne(e => e.PhieuNhap);

            modelBuilder.Entity<PhieuXuat>()
              .HasMany(e => e.PhieuXuatChiTiets)
              .WithOne(e => e.PhieuXuat);


            modelBuilder.Entity<NhanVien>()
               .HasMany(e => e.HoaDons)
               .WithOne(e => e.NhanVien);
            modelBuilder.Entity<NhanVien>()
               .HasMany(e => e.PhieuKiemKes)
               .WithOne(e => e.NhanVien);
            modelBuilder.Entity<NhanVien>()
               .HasMany(e => e.PhieuXuats)
               .WithOne(e => e.NhanVien);
            modelBuilder.Entity<NhanVien>()
               .HasMany(e => e.PhieuNhaps)
               .WithOne(e => e.NhanVien);

            modelBuilder.Entity<MatHang>()
               .HasMany(e => e.ChiTietHoaDons)
               .WithOne(e => e.MatHang);
            modelBuilder.Entity<MatHang>()
              .HasMany(e => e.PhieuKiemKeChiTiets)
              .WithOne(e => e.MatHang);
            modelBuilder.Entity<MatHang>()
              .HasMany(e => e.PhieuNhapChiTiets)
              .WithOne(e => e.MatHang);
            modelBuilder.Entity<MatHang>()
              .HasMany(e => e.PhieuXuatChiTiets)
              .WithOne(e => e.MatHang);
            modelBuilder.Entity<PhieuKiemKe>()
              .HasMany(e => e.PhieuKiemKeChiTiets)
              .WithOne(e => e.PhieuKiemKe);
            modelBuilder.Entity<MatHang>()
              .HasMany(e => e.ChiTietHoaDons)
              .WithOne(e => e.MatHang);
            modelBuilder.ApplyConfiguration(new MatHangConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietHoaDonConfiguaration());
            modelBuilder.ApplyConfiguration(new ChucVuConfiguaration());
            modelBuilder.ApplyConfiguration(new ChungLoaiConfiguaration());
            modelBuilder.ApplyConfiguration(new DonViTinhConfiguaration());
            modelBuilder.ApplyConfiguration(new HoaDonConfiguaration());
            modelBuilder.ApplyConfiguration(new KhachHangConfiguaration());
            modelBuilder.ApplyConfiguration(new LoaiHangConfiguaration());
            modelBuilder.ApplyConfiguration(new NhaCungCapConfiguaration());
            modelBuilder.ApplyConfiguration(new NhanVienConfiguaration());
            modelBuilder.ApplyConfiguration(new PhieuKiemKeChiTietConfiguaration());
            modelBuilder.ApplyConfiguration(new PhieuKiemKeConfiguaration());
            modelBuilder.ApplyConfiguration(new PhieuNhapChiTietConfiguaration());
            modelBuilder.ApplyConfiguration(new PhieuNhapConfiguaration());
            modelBuilder.ApplyConfiguration(new PhieuXuatConfiguaration());
            modelBuilder.ApplyConfiguration(new PhieuXuatChiTietConfiguaration());
            modelBuilder.Entity<MatHang>().ToTable("MatHang");
            modelBuilder.Entity<ChiTietHoaDon>().ToTable("ChiTietHoaDon");
            modelBuilder.Entity<ChucVu>().ToTable("ChucVu");
            modelBuilder.Entity<ChungLoai>().ToTable("ChungLoai");
            modelBuilder.Entity<DonViTinh>().ToTable("DonViTinh");
            modelBuilder.Entity<HoaDon>().ToTable("HoaDon");
            modelBuilder.Entity<KhachHang>().ToTable("KhachHang");
            modelBuilder.Entity<LoaiHang>().ToTable("LoaiHang");
            modelBuilder.Entity<NhaCungCap>().ToTable("NhaCungCap");
            modelBuilder.Entity<NhanVien>().ToTable("NhanVien");
            modelBuilder.Entity<PhieuKiemKe>().ToTable("PhieuKiemKe");
            modelBuilder.Entity<PhieuKiemKeChiTiet>().ToTable("PhieuKiemKeChiTiet");
            modelBuilder.Entity<PhieuNhap>().ToTable("PhieuNhap");
            modelBuilder.Entity<PhieuNhapChiTiet>().ToTable("PhieuNhapChiTiet");
            modelBuilder.Entity<PhieuXuat>().ToTable("PhieuXuat");
            modelBuilder.Entity<PhieuXuatChiTiet>().ToTable("PhieuXuatChiTiet");
        }
    }
}
