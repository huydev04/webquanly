using Admin.ControlData;
using Admin.Models;
using Admin.Models.State;
using Microsoft.AspNetCore.Mvc;
using Nome.Recieve;
namespace Admin.Controllers
{
    public class DonHangController : Controller
    {
        private readonly WebDataContext _webDataContext;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public DonHangController(WebDataContext webDataContext, IWebHostEnvironment hostingEnvironment)
        {
            _webDataContext = webDataContext;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            List<KhachHang> kh = _webDataContext.KhachHangs.ToList();
            List<DonHang> dh = ReadJson.getList(kh);
            if (dh == null)
            {
                TempData["OrderIsNull"] = "Hiện tại không có đơn hàng";
                return RedirectToAction("Index", "Home");
            }
            return View(dh);
        }

        public IActionResult SeeOrder(string id)
        {
            KhachHang kh = _webDataContext.KhachHangs.FirstOrDefault(kh => kh.IdDonHang == id);

            List<OrderProduct> orderProducts = ReadJson.getListOrder(kh);
            return View(orderProducts);
        }

        public IActionResult AcceptOrder(string id)
        {
            KhachHang kh = _webDataContext.KhachHangs.FirstOrDefault(kh => kh.IdDonHang == id);
            List<OrderProduct> orderProducts = ReadJson.getListOrder(kh);
            DonHang donHang = _webDataContext.DonHangs.FirstOrDefault(dh => dh.IdDonHang == kh.IdDonHang);
            Report.CreateWordReport(kh, donHang, orderProducts);
            StateOrder state = new StateOrder();
            state.IdKH = kh.IdKh;
            state.TrangThai = "Đã duyệt";
            ReadJson.UpdateStateDonHang(state, kh);
            string path = @"../Admin/StoreData/DonHang/" + kh.IdKh + ".json";
            System.IO.File.Delete(path);
            string path2 = @"../Admin/StoreData/SanPhamDaDat/" + kh.IdKh + ".json";
            System.IO.File.Delete(path2);
            return RedirectToAction("Index");
        }

        public IActionResult CancelOrder(string id)
        {
            KhachHang kh = _webDataContext.KhachHangs.FirstOrDefault(kh => kh.IdDonHang == id);
            StateOrder state = new StateOrder();
            state.IdKH = kh.IdKh;
            state.TrangThai = "Đã huỷ";
            ReadJson.UpdateStateDonHang(state, kh);
            string path = @"../Admin/StoreData/DonHang/" + kh.IdKh + ".json";
            System.IO.File.Delete(path);
            string path2 = @"../Admin/StoreData/SanPhamDaDat/" + kh.IdKh + ".json";
            System.IO.File.Delete(path2);
            return RedirectToAction("Index");
        }

        public IActionResult DonDaDuyet()
        {
            string relativePath = @"\wwwroot\reports\"; // Thư mục tương đối từ thư mục gốc nội dung của ứng dụng
            string folderPath = Path.Combine(_hostingEnvironment.ContentRootPath, relativePath);
            if (!Directory.Exists(folderPath))
            {
                return NotFound();
            }

            // Lấy danh sách thư mục và tệp tin
            var directories = Directory.GetDirectories(folderPath);
            var files = Directory.GetFiles(folderPath);

            var model = new FileManagerViewModel
            {
                Directories = directories,
                Files = files
            };

            return View(model);
        }
    }
}
