using Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Admin.Controllers
{
    public class KhachHangsController : Controller
    {
        private readonly WebDataContext _context;

        public KhachHangsController(WebDataContext context)
        {
            _context = context;
        }

        // GET: KhachHangs
        public async Task<IActionResult> Index()
        {
            var webDataContext = _context.KhachHangs.Include(k => k.IdDonHangNavigation).Include(k => k.IdGioHangNavigation);
            return View(await webDataContext.ToListAsync());
        }
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

        // GET: KhachHangs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = await _context.KhachHangs
                .Include(k => k.IdDonHangNavigation)
                .Include(k => k.IdGioHangNavigation)
                .FirstOrDefaultAsync(m => m.IdKh == id);
            if (khachHang == null)
            {
                return NotFound();
            }

            return View(khachHang);
        }

        // GET: KhachHangs/Create
        public IActionResult Create()
        {
            KhachHang kh = new KhachHang();
            kh.IdKh = codeRandom();
            kh.IdGioHang = kh.IdKh;
            kh.IdDonHang = null;
            return View(kh);
        }

        // POST: KhachHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdKh,HoTenKh,NgaySinh,DiaChi,Email,Std,GiayPhep,TichDiem,MatKhau,LoaiKh,IdGioHang,IdDonHang")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                GioHang gh = new GioHang();
                gh.IdGioHang = khachHang.IdKh;
                gh.IdKh = khachHang.IdKh;
                gh.DsSanPham = null;
                _context.GioHangs.Add(gh);
                _context.KhachHangs.Add(khachHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDonHang"] = new SelectList(_context.DonHangs, "IdDonHang", "IdDonHang", khachHang.IdDonHang);
            ViewData["IdGioHang"] = new SelectList(_context.GioHangs, "IdGioHang", "IdGioHang", khachHang.IdGioHang);
            return View(khachHang);
        }

        // GET: KhachHangs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = await _context.KhachHangs.FindAsync(id);
            if (khachHang == null)
            {
                return NotFound();
            }
            ViewData["IdDonHang"] = new SelectList(_context.DonHangs, "IdDonHang", "IdDonHang", khachHang.IdDonHang);
            ViewData["IdGioHang"] = new SelectList(_context.GioHangs, "IdGioHang", "IdGioHang", khachHang.IdGioHang);
            return View(khachHang);
        }

        // POST: KhachHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdKh,HoTenKh,NgaySinh,DiaChi,Email,Std,GiayPhep,TichDiem,MatKhau,LoaiKh,IdGioHang,IdDonHang")] KhachHang khachHang)
        {
            if (id != khachHang.IdKh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khachHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhachHangExists(khachHang.IdKh))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDonHang"] = new SelectList(_context.DonHangs, "IdDonHang", "IdDonHang", khachHang.IdDonHang);
            ViewData["IdGioHang"] = new SelectList(_context.GioHangs, "IdGioHang", "IdGioHang", khachHang.IdGioHang);
            return View(khachHang);
        }

        // GET: KhachHangs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = await _context.KhachHangs
                .Include(k => k.IdDonHangNavigation)
                .Include(k => k.IdGioHangNavigation)
                .FirstOrDefaultAsync(m => m.IdKh == id);
            if (khachHang == null)
            {
                return NotFound();
            }

            return View(khachHang);
        }

        // POST: KhachHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var khachHang = await _context.KhachHangs.FindAsync(id);
            if (khachHang != null)
            {
                _context.KhachHangs.Remove(khachHang);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhachHangExists(string id)
        {
            return _context.KhachHangs.Any(e => e.IdKh == id);
        }
    }
}
