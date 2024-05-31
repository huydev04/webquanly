using System;
using System.Collections.Generic;

namespace Nome.Models;

public partial class NhomThuoc
{
    public string IdNhomThuoc { get; set; } = null!;

    public string? TenNhomThuoc { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
