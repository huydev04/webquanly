using System;
using System.Collections.Generic;

namespace Admin.Models;

public partial class GioHang
{
    public string IdGioHang { get; set; } = null!;

    public string? IdKh { get; set; }

    public string? DsSanPham { get; set; }

    public virtual ICollection<KhachHang> KhachHangs { get; set; } = new List<KhachHang>();
}
