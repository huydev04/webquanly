using System;
using System.Collections.Generic;

namespace Nome.Models;

public partial class SanPham
{
    public string IdSanPham { get; set; } = null!;

    public string? TenSanPham { get; set; }

    public string? ThanhPhan { get; set; }

    public string? HinhDang { get; set; }

    public int? HamLuong { get; set; }

    public string? DonVi { get; set; }

    public string? NuocSx { get; set; }

    public DateOnly? HanSuDung { get; set; }

    public decimal? Gia { get; set; }

    public string? HinhAnhThuoc { get; set; }

    public int? SoLuongTonKho { get; set; }

    public string? IdNhomThuoc { get; set; }

    public string? IdNhaCungCap { get; set; }

    public virtual NhaCungCap? IdNhaCungCapNavigation { get; set; }

    public virtual NhomThuoc? IdNhomThuocNavigation { get; set; }
}
