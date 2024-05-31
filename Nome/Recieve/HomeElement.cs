using Nome.Models;
using Nome.ProcessFlow;

namespace Nome.Recieve
{
    public class HomeElements
    {
        private KhachHang kh;
        private List<SanPham> danhSachSanPham;
        private OrderItemToCart _item;
        private List<OrderProduct> cart;
        public OrderView orderView { get; set; }
        public HomeElements()
        {
        }

        public HomeElements(KhachHang userKH)
        {
            kh = userKH;
        }
        public HomeElements(KhachHang userKH, List<SanPham> ds, OrderItemToCart item)
        {
            kh = userKH;
            danhSachSanPham = ds;
            _item = item;
        }

        public KhachHang getKhachHangInfo()
        {
            return kh;
        }
        public List<SanPham> getDanhSachSanPham()
        {
            return danhSachSanPham.ToList();
        }
        public OrderItemToCart getItemOrder()
        {
            return _item;
        }
        public List<OrderProduct> getCart()
        {
            List<OrderProduct> cart = CartReadJson.getList();
            return cart;
        }
    }
}
