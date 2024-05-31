using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nome.Models;

public partial class WebDataContext : DbContext
{
    public WebDataContext()
    {
    }

    public WebDataContext(DbContextOptions<WebDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BaoCao> BaoCaos { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<GioHang> GioHangs { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiBaoCao> LoaiBaoCaos { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<NhomThuoc> NhomThuocs { get; set; }

    public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }

    public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }

    public virtual DbSet<Pttt> Pttts { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<ThongBao> ThongBaos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-QU338JM\\SQLEXPRESS;Initial Catalog=WebData;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BaoCao>(entity =>
        {
            entity.HasKey(e => e.IdBaoCao).HasName("PK__BaoCao__7CD89F4A905DE8EB");

            entity.ToTable("BaoCao");

            entity.Property(e => e.IdBaoCao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_baoCao");
            entity.Property(e => e.IdLoaiBaoCao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_loaiBaoCao");
            entity.Property(e => e.NgayBaoCao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("ngayBaoCao");
            entity.Property(e => e.NoiDungBaoCao)
                .HasColumnType("text")
                .HasColumnName("noiDungBaoCao");
            entity.Property(e => e.TieuDeBaoCao).HasColumnName("tieuDeBaoCao");

            entity.HasOne(d => d.IdLoaiBaoCaoNavigation).WithMany(p => p.BaoCaos)
                .HasForeignKey(d => d.IdLoaiBaoCao)
                .HasConstraintName("FK__BaoCao__id_loaiB__5441852A");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.IdChucVu).HasName("PK__ChucVu__B4D5AD170F313A61");

            entity.ToTable("ChucVu");

            entity.Property(e => e.IdChucVu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_chucVu");
            entity.Property(e => e.TenChucVu)
                .HasMaxLength(100)
                .HasColumnName("tenChucVu");
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
            entity.HasKey(e => e.IdDonHang).HasName("PK__DonHang__30EB9BAF7D6320DF");

            entity.ToTable("DonHang");

            entity.Property(e => e.IdDonHang)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_donHang");
            entity.Property(e => e.Chietkhau).HasColumnName("chietkhau");
            entity.Property(e => e.DiaChiNhanHang).HasColumnName("diaChiNhanHang");
            entity.Property(e => e.DsSanPham).HasColumnName("dsSanPham");
            entity.Property(e => e.IdPttt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_PTTT");
            entity.Property(e => e.NgayTaoDonHang)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("ngayTaoDonHang");
            entity.Property(e => e.ThanhTien)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("thanhTien");

            entity.HasOne(d => d.IdPtttNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.IdPttt)
                .HasConstraintName("FK__DonHang__id_PTTT__5535A963");
        });

        modelBuilder.Entity<GioHang>(entity =>
        {
            entity.HasKey(e => e.IdGioHang).HasName("PK__GioHang__B3169E9AF8D31D30");

            entity.ToTable("GioHang");

            entity.Property(e => e.IdGioHang)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_gioHang");
            entity.Property(e => e.DsSanPham).HasColumnName("dsSanPham");
            entity.Property(e => e.IdKh)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("id_KH");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.IdKh).HasName("PK__KhachHan__01489A01B9760AE7");

            entity.ToTable("KhachHang");

            entity.Property(e => e.IdKh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_KH");
            entity.Property(e => e.DiaChi).HasColumnName("diaChi");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.GiayPhep)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("giayPhep");
            entity.Property(e => e.HoTenKh)
                .HasMaxLength(100)
                .HasColumnName("hoTenKH");
            entity.Property(e => e.IdDonHang)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_donHang");
            entity.Property(e => e.IdGioHang)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_gioHang");
            entity.Property(e => e.LoaiKh)
                .HasMaxLength(100)
                .HasColumnName("loaiKH");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("matKhau");
            entity.Property(e => e.NgaySinh).HasColumnName("ngaySinh");
            entity.Property(e => e.Std)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("std");
            entity.Property(e => e.TichDiem)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("tichDiem");

            entity.HasOne(d => d.IdDonHangNavigation).WithMany(p => p.KhachHangs)
                .HasForeignKey(d => d.IdDonHang)
                .HasConstraintName("FK__KhachHang__id_do__5629CD9C");

            entity.HasOne(d => d.IdGioHangNavigation).WithMany(p => p.KhachHangs)
                .HasForeignKey(d => d.IdGioHang)
                .HasConstraintName("FK__KhachHang__id_gi__571DF1D5");
        });

        modelBuilder.Entity<LoaiBaoCao>(entity =>
        {
            entity.HasKey(e => e.IdLoaiBaoCao).HasName("PK__LoaiBaoC__A2CA5EF617A0A7DF");

            entity.ToTable("LoaiBaoCao");

            entity.Property(e => e.IdLoaiBaoCao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_loaiBaoCao");
            entity.Property(e => e.TenLoaiBaoCao)
                .HasMaxLength(300)
                .HasColumnName("tenLoaiBaoCao");
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.IdNhaCungCap).HasName("PK__NhaCungC__5E687893211AA9DA");

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.IdNhaCungCap)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_nhaCungCap");
            entity.Property(e => e.TenNhaCungCap).HasColumnName("tenNhaCungCap");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.IdNv).HasName("PK__NhanVien__01498F85D1676F54");

            entity.ToTable("NhanVien");

            entity.Property(e => e.IdNv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_NV");
            entity.Property(e => e.DiaChi)
                .HasColumnType("text")
                .HasColumnName("diaChi");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.HoTenNv)
                .HasMaxLength(300)
                .HasColumnName("hoTenNV");
            entity.Property(e => e.IdBaoCao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_baoCao");
            entity.Property(e => e.IdChucVu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_chucVu");
            entity.Property(e => e.IdPnh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_PNH");
            entity.Property(e => e.IdPxh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_PXH");
            entity.Property(e => e.IdThongBao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_thongBao");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("matKhau");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sdt");

            entity.HasOne(d => d.IdBaoCaoNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.IdBaoCao)
                .HasConstraintName("FK__NhanVien__id_bao__5812160E");

            entity.HasOne(d => d.IdChucVuNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.IdChucVu)
                .HasConstraintName("FK__NhanVien__id_chu__59063A47");

            entity.HasOne(d => d.IdPnhNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.IdPnh)
                .HasConstraintName("FK__NhanVien__id_PNH__59FA5E80");

            entity.HasOne(d => d.IdPxhNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.IdPxh)
                .HasConstraintName("FK__NhanVien__id_PXH__5AEE82B9");

            entity.HasOne(d => d.IdThongBaoNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.IdThongBao)
                .HasConstraintName("FK__NhanVien__id_tho__5BE2A6F2");
        });

        modelBuilder.Entity<NhomThuoc>(entity =>
        {
            entity.HasKey(e => e.IdNhomThuoc).HasName("PK__NhomThuo__03D8C5464E41AC61");

            entity.ToTable("NhomThuoc");

            entity.Property(e => e.IdNhomThuoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_nhomThuoc");
            entity.Property(e => e.TenNhomThuoc).HasColumnName("tenNhomThuoc");
        });

        modelBuilder.Entity<PhieuNhap>(entity =>
        {
            entity.HasKey(e => e.IdPnh).HasName("PK__PhieuNha__76C1802CB1BBA39B");

            entity.ToTable("PhieuNhap");

            entity.Property(e => e.IdPnh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_PNH");
            entity.Property(e => e.DsSanPham).HasColumnName("dsSanPham");
            entity.Property(e => e.GhiChu)
                .HasColumnType("text")
                .HasColumnName("ghiChu");
            entity.Property(e => e.IdNhaCungCap)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_nhaCungCap");
            entity.Property(e => e.NgayNhapHang)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("ngayNhapHang");
        });

        modelBuilder.Entity<PhieuXuat>(entity =>
        {
            entity.HasKey(e => e.IdPxh).HasName("PK__PhieuXua__76CD7EF7B3C552BB");

            entity.ToTable("PhieuXuat");

            entity.Property(e => e.IdPxh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_PXH");
            entity.Property(e => e.GhiChu)
                .HasColumnType("text")
                .HasColumnName("ghiChu");
            entity.Property(e => e.IdDonHang)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_donHang");
            entity.Property(e => e.NgayXuatHang)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("ngayXuatHang");

            entity.HasOne(d => d.IdDonHangNavigation).WithMany(p => p.PhieuXuats)
                .HasForeignKey(d => d.IdDonHang)
                .HasConstraintName("FK__PhieuXuat__id_do__5CD6CB2B");
        });

        modelBuilder.Entity<Pttt>(entity =>
        {
            entity.HasKey(e => e.IdPttt).HasName("PK__PTTT__10AA5FB1F392BDA0");

            entity.ToTable("PTTT");

            entity.Property(e => e.IdPttt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_PTTT");
            entity.Property(e => e.TenLoaiPt)
                .HasMaxLength(100)
                .HasColumnName("tenLoaiPT");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.IdSanPham).HasName("PK__SanPham__771449476F191907");

            entity.ToTable("SanPham");

            entity.Property(e => e.IdSanPham)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_sanPham");
            entity.Property(e => e.DonVi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("donVi");
            entity.Property(e => e.Gia)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("gia");
            entity.Property(e => e.HamLuong).HasColumnName("hamLuong");
            entity.Property(e => e.HanSuDung).HasColumnName("hanSuDung");
            entity.Property(e => e.HinhAnhThuoc).HasColumnName("hinhAnhThuoc");
            entity.Property(e => e.HinhDang)
                .HasMaxLength(100)
                .HasColumnName("hinhDang");
            entity.Property(e => e.IdNhaCungCap)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_nhaCungCap");
            entity.Property(e => e.IdNhomThuoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_nhomThuoc");
            entity.Property(e => e.NuocSx)
                .HasMaxLength(100)
                .HasColumnName("nuocSX");
            entity.Property(e => e.SoLuongTonKho).HasColumnName("soLuongTonKho");
            entity.Property(e => e.TenSanPham).HasColumnName("tenSanPham");
            entity.Property(e => e.ThanhPhan).HasColumnName("thanhPhan");

            entity.HasOne(d => d.IdNhaCungCapNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdNhaCungCap)
                .HasConstraintName("FK__SanPham__id_nhaC__5DCAEF64");

            entity.HasOne(d => d.IdNhomThuocNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdNhomThuoc)
                .HasConstraintName("FK__SanPham__id_nhom__5EBF139D");
        });

        modelBuilder.Entity<ThongBao>(entity =>
        {
            entity.HasKey(e => e.IdThongBao).HasName("PK__ThongBao__B5EB7EF7F06EB698");

            entity.ToTable("ThongBao");

            entity.Property(e => e.IdThongBao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_thongBao");
            entity.Property(e => e.NoiDungThongBao)
                .HasColumnType("text")
                .HasColumnName("noiDungThongBao");
            entity.Property(e => e.PhanAnh).HasColumnName("phanAnh");
            entity.Property(e => e.TieuDeThongBao).HasColumnName("tieuDeThongBao");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
