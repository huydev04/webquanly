using System;
using System.Collections.Generic;

namespace Nome.Models;

public partial class PhieuXuat
{
    public string IdPxh { get; set; } = null!;

    public DateTime? NgayXuatHang { get; set; }

    public string? GhiChu { get; set; }

    public string? IdDonHang { get; set; }

    public virtual DonHang? IdDonHangNavigation { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
