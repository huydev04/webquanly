using Microsoft.AspNetCore.Mvc;
using Nome.Models;
using Nome.ProcessFlow;
using Nome.Recieve;

namespace Nome.Controllers
{
    public class CartController : Controller
    {
        WebDataContext cn = new WebDataContext();

        public bool CheckExit(List<OrderProduct> ds, OrderItemToCart item)
        {
            foreach (var order in ds)
            {
                if (order.Id == item.Id)
                {
                    return true;
                }
            }
            return false;
        }
        public void updateItem(List<OrderProduct> ds, OrderItemToCart item)
        {
            var sanPham = cn.SanPhams.FirstOrDefault(s => s.IdSanPham == item.Id);
            foreach (OrderProduct p in ds)
            {
                if (p.Id == sanPham.IdSanPham)
                {
                    if (p.SoLuong == 1)
                    {
                        p.SoLuong += 1;
                    }
                    else
                    {
                        p.SoLuong = item.SoLuong;
                    }

                }
            }
        }

        public IActionResult Index()
        {
            HomeElements el = new HomeElements();
            if (el.getCart() == null)
            {
                TempData["CartIsNull"] = "Giỏ trống không xem được";
                return RedirectToAction("Index", "Home");
            }
            return View(el);
        }

        [HttpPost]
        public IActionResult AddToCart(OrderItemToCart item)
        {
            OrderProduct orderProduct = new OrderProduct();
            SanPham sanPham = cn.SanPhams.FirstOrDefault(p => p.IdSanPham.Equals(item.Id));
            UserState.stateCart = CartReadJson.getList();
            if (UserState.stateCart == null)
            {
                UserState.stateCart = new List<OrderProduct>();
                orderProduct.Id = sanPham.IdSanPham;
                orderProduct.TenSanPham = sanPham.TenSanPham;
                orderProduct.HinhAnhSP = sanPham.HinhAnhThuoc;
                orderProduct.Gia = sanPham.Gia;
                orderProduct.SoLuong = item.SoLuong;
                UserState.stateCart.Add(orderProduct);
                CartReadJson.setList(UserState.stateCart);
                string filePath = "";
                filePath = "~Admin/StoreData/" + UserState.UserLog().IdKh + ".json";
                var gioHang = cn.GioHangs.FirstOrDefault(u => u.IdKh == UserState.UserLog().IdKh);
                gioHang.DsSanPham = filePath;
                cn.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                if (CheckExit(UserState.stateCart, item) == false)
                {
                    orderProduct.Id = sanPham.IdSanPham;
                    orderProduct.TenSanPham = sanPham.TenSanPham;
                    orderProduct.HinhAnhSP = sanPham.HinhAnhThuoc;
                    orderProduct.Gia = sanPham.Gia;
                    orderProduct.SoLuong = item.SoLuong;
                    var orderItem = cn.SanPhams.FirstOrDefault(u => u.IdSanPham == item.Id);
                    UserState.stateCart.Add(orderProduct);
                    CartReadJson.setList(UserState.stateCart);
                }
                else
                {
                    updateItem(UserState.stateCart, item);
                    CartReadJson.setList(UserState.stateCart);
                }

                return RedirectToAction("Index", "Home");
            }
            return Json(new { success = false });
        }
        public IActionResult DeleteOrderItem(string id)
        {
            HomeElements el = new HomeElements();
            var item = el.getCart().FirstOrDefault(u => u.Id == id);
            var listOrder = CartReadJson.getList();
            foreach (var i in listOrder)
            {
                if (i.Id == item.Id)
                {
                    listOrder.Remove(i);
                    CartReadJson.setList(listOrder);
                    return RedirectToAction("Index", "Cart");
                }
            }
            return View();

        }

        public IActionResult PayOrder()
        {
            HomeElements el = new HomeElements(UserState.UserLog());
            return View(el);
        }

        [HttpPost]
        [ActionName("PayOrder")]
        public IActionResult PayOrderPost(HomeElements el)
        {
            OrderView item = el.orderView;
            DonHang dh = new DonHang();
            List<DonHang> listDonHang = new List<DonHang>();
            string path = "";
            foreach (var i in UserState.statelogin)
            {
                dh.IdDonHang = i.IdKh;
                dh.DsSanPham = @"../Admin/StoreData/" + i.IdKh + ".json";
                path = @"../Admin/StoreData/" + i.IdKh + ".json";
            }
            dh.NgayTaoDonHang = DateTime.Now;
            dh.DiaChiNhanHang = item.DiaChi;
            dh.Chietkhau = null;
            dh.ThanhTien = item.ThanhTien;
            dh.IdPttt = item.Id_PTTT;
            cn.DonHangs.Add(dh);
            TempData["OrderSuccess"] = "Bạn đã đặt hàng thành công";
            listDonHang.Add(dh);
            KhachHang kh = cn.KhachHangs.FirstOrDefault(kh => kh.IdKh == UserState.UserLog().IdKh);
            kh.IdDonHang = dh.IdDonHang;
            CartReadJson.setOrderList(listDonHang);
            List<OrderProduct> orderProducts = el.getCart();
            CartReadJson.SaveOrderList(orderProducts);
            cn.Update(kh);
            cn.SaveChanges();
            System.IO.File.Delete(path);
            return RedirectToAction("Index", "Home");
        }
    }
}
