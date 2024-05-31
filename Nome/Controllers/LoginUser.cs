using Microsoft.AspNetCore.Mvc;
using Nome.Models;
using Nome.Recieve;

namespace Nome.Controllers
{
    public class LoginUser : Controller
    {
        WebDataContext cn = new WebDataContext();
        string codeRandom()
        {
            char[] characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            // Sử dụng Random để chọn ngẫu nhiên các ký tự và số từ mảng
            Random random = new Random();
            // Tạo một chuỗi có độ dài 6 với các ký tự và số ngẫu nhiên
            string maTinhYeu = "";
            for (int i = 0; i < 6; i++)
            {
                // Chọn một phần tử ngẫu nhiên từ mảng characters
                maTinhYeu += characters[random.Next(characters.Length)];
            }
            return maTinhYeu;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Register")]
        public async Task<IActionResult> RegisterPost(RegisterCustomer newCustomer)
        {
            var ExistCustome = cn.KhachHangs.FirstOrDefault(u => u.Email == newCustomer.Email);
            if (ExistCustome != null)
            {
                TempData["AccountExist"] = "Tài khoản đã tồn tại";
                return View();
            }
            else
            {
                KhachHang addNewCustomer = new KhachHang();
                GioHang gioHangofNewCustmor = new GioHang();
                if (ModelState.IsValid)
                {
                    addNewCustomer.Email = newCustomer.Email;
                    addNewCustomer.IdKh = codeRandom();
                    addNewCustomer.HoTenKh = newCustomer.HoTenKh;
                    addNewCustomer.Std = newCustomer.Std;
                    addNewCustomer.NgaySinh = newCustomer.NgaySinh;
                    addNewCustomer.DiaChi = newCustomer.DiaChi;
                    addNewCustomer.MatKhau = newCustomer.MatKhau;
                    addNewCustomer.GiayPhep = null;
                    addNewCustomer.TichDiem = null;
                    addNewCustomer.LoaiKh = null;
                    addNewCustomer.IdDonHang = null;
                    gioHangofNewCustmor.IdGioHang = addNewCustomer.IdKh + 'K';
                    gioHangofNewCustmor.IdKh = addNewCustomer.IdKh;
                    gioHangofNewCustmor.DsSanPham = null;
                    addNewCustomer.IdGioHang = addNewCustomer.IdKh;
                    TempData["LoginSuccess"] = "Đăng ký thành công tài khoản của bạn";
                    cn.KhachHangs.Add(addNewCustomer);
                    cn.GioHangs.Add(gioHangofNewCustmor);
                    cn.SaveChanges();
                    return RedirectToAction("Login");
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Login")]
        public IActionResult LoginPost(LoginCustomer loginInto)
        {
            if (ModelState.IsValid)
            {
                var CustomerLoginto = cn.KhachHangs.FirstOrDefault(u => u.Email == loginInto.Email && u.MatKhau == loginInto.MatKhau);
                if (CustomerLoginto == null)
                {
                    TempData["AccountNotExist"] = "Tài khoản không tồn tại tồn tại";
                    return View();
                }
                else
                {
                    KhachHang kh = CustomerLoginto;
                    UserState.statelogin.Add(kh);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }




    }
}
