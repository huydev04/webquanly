using System;
using System.Collections.Generic;

namespace Nome.Models;

public partial class KhachHang
{
    public string IdKh { get; set; } = null!;

    public string? HoTenKh { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public string? DiaChi { get; set; }

    public string? Email { get; set; }

    public string? Std { get; set; }

    public string? GiayPhep { get; set; }

    public decimal? TichDiem { get; set; }

    public string? MatKhau { get; set; }

    public string? LoaiKh { get; set; }

    public string? IdGioHang { get; set; }

    public string? IdDonHang { get; set; }

    public virtual DonHang? IdDonHangNavigation { get; set; }

    public virtual GioHang? IdGioHangNavigation { get; set; }
}
