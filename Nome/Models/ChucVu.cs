using System;
using System.Collections.Generic;

namespace Nome.Models;

public partial class ChucVu
{
    public string IdChucVu { get; set; } = null!;

    public string? TenChucVu { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
