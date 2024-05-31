using System.ComponentModel.DataAnnotations;

namespace Nome.Recieve
{
    public class OrderProduct
    {
        [Key] public string Id { get; set; }
        public string? TenSanPham { get; set; }
        public string? HinhAnhSP { get; set; }
        public int? SoLuong { get; set; }
        public decimal? Gia { get; set; }
    }
}
