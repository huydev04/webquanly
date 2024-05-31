using System;
using System.Collections.Generic;

namespace Nome.Models;

public partial class PhieuNhap
{
    public string IdPnh { get; set; } = null!;

    public string? IdNhaCungCap { get; set; }

    public DateTime? NgayNhapHang { get; set; }

    public string? DsSanPham { get; set; }

    public string? GhiChu { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
