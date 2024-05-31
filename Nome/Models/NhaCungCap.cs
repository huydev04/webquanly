using System;
using System.Collections.Generic;

namespace Nome.Models;

public partial class NhaCungCap
{
    public string IdNhaCungCap { get; set; } = null!;

    public string? TenNhaCungCap { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
