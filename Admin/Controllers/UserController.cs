using Admin.ControlData;
using Admin.Models;
using Admin.ReceiveDataFromView;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class UserController : Controller
    {
        WebDataContext cn = new WebDataContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Login")]
        public IActionResult LoginPost(DataFormLogin item)
        {
            if (ModelState.IsValid)
            {
                var nv = cn.NhanViens.FirstOrDefault(u => u.Email == item.Email && u.MatKhau == item.Password);
                if (nv != null)
                {
                    StateAdmin.nv = nv;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["AccountNotExist"] = "Tải khoản này không phải nhân viên của công ty";
                }
            }
            return View();
        }
    }
}
