using System;
using System.Collections.Generic;

namespace Nome.Models;

public partial class DonHang
{
    public string IdDonHang { get; set; } = null!;

    public DateTime? NgayTaoDonHang { get; set; }

    public string? DiaChiNhanHang { get; set; }

    public string? DsSanPham { get; set; }

    public int? Chietkhau { get; set; }

    public decimal? ThanhTien { get; set; }

    public string? IdPttt { get; set; }

    public virtual Pttt? IdPtttNavigation { get; set; }

    public virtual ICollection<KhachHang> KhachHangs { get; set; } = new List<KhachHang>();

    public virtual ICollection<PhieuXuat> PhieuXuats { get; set; } = new List<PhieuXuat>();
}
