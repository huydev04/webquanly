using System;
using System.Collections.Generic;

namespace Admin.Models;

public partial class LoaiBaoCao
{
    public string IdLoaiBaoCao { get; set; } = null!;

    public string? TenLoaiBaoCao { get; set; }

    public virtual ICollection<BaoCao> BaoCaos { get; set; } = new List<BaoCao>();
}
