using System;
using System.Collections.Generic;

namespace Admin.Models;

public partial class ThongBao
{
    public string IdThongBao { get; set; } = null!;

    public string? TieuDeThongBao { get; set; }

    public string? NoiDungThongBao { get; set; }

    public string? PhanAnh { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
