using System;
using System.Collections.Generic;

namespace Admin.Models;

public partial class BaoCao
{
    public string IdBaoCao { get; set; } = null!;

    public string? TieuDeBaoCao { get; set; }

    public string? IdLoaiBaoCao { get; set; }

    public string? NoiDungBaoCao { get; set; }

    public DateTime? NgayBaoCao { get; set; }

    public virtual LoaiBaoCao? IdLoaiBaoCaoNavigation { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
