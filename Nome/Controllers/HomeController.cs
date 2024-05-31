using Microsoft.AspNetCore.Mvc;
using Nome.Models;
using Nome.Recieve;
using System.Diagnostics;

namespace Nome.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        WebDataContext cn = new WebDataContext();
        //List<KhachHang> UserLoged = new List<KhachHang>();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (UserState.statelogin.Count == 0)
            {
                return RedirectToAction("Login", "LoginUser");
            }
            else
            {
                KhachHang kh = new KhachHang();
                //give the information of custome in database
                foreach (var i in UserState.statelogin)
                {
                    kh.IdKh = i.IdKh;
                    kh.HoTenKh = i.HoTenKh;
                    kh.NgaySinh = i.NgaySinh;
                    kh.DiaChi = i.DiaChi;
                    kh.Email = i.Email;
                    kh.Std = i.Std;
                    kh.GiayPhep = i.GiayPhep;
                    kh.TichDiem = i.TichDiem;
                    kh.MatKhau = i.MatKhau;
                    kh.LoaiKh = i.LoaiKh;
                    kh.IdDonHang = i.IdDonHang;
                    kh.IdGioHang = i.IdGioHang;
                }
                TempData["Account"] = kh.HoTenKh;
                List<SanPham> sanPham = cn.SanPhams.ToList();
                OrderItemToCart item = new OrderItemToCart();
                HomeElements element = new HomeElements(kh, sanPham, item);
                return View(element);
            }
        }

        public IActionResult Logout()
        {
            UserState.statelogin.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult StateOrder()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
