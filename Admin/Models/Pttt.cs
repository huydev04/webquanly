using System;
using System.Collections.Generic;

namespace Admin.Models;

public partial class Pttt
{
    public string IdPttt { get; set; } = null!;

    public string? TenLoaiPt { get; set; }

    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();
}
