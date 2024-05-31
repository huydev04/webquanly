using System;
using System.Collections.Generic;

namespace Nome.Models;

public partial class NhanVien
{
    public string IdNv { get; set; } = null!;

    public string? HoTenNv { get; set; }

    public string? Email { get; set; }

    public string? Sdt { get; set; }

    public string? DiaChi { get; set; }

    public string? MatKhau { get; set; }

    public string? IdChucVu { get; set; }

    public string? IdPnh { get; set; }

    public string? IdPxh { get; set; }

    public string? IdBaoCao { get; set; }

    public string? IdThongBao { get; set; }

    public virtual BaoCao? IdBaoCaoNavigation { get; set; }

    public virtual ChucVu? IdChucVuNavigation { get; set; }

    public virtual PhieuNhap? IdPnhNavigation { get; set; }

    public virtual PhieuXuat? IdPxhNavigation { get; set; }

    public virtual ThongBao? IdThongBaoNavigation { get; set; }
}
