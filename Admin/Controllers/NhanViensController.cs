using Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Admin.Controllers
{
    public class NhanViensController : Controller
    {
        private readonly WebDataContext _context;

        public NhanViensController(WebDataContext context)
        {
            _context = context;
        }

        // GET: NhanViens
        public async Task<IActionResult> Index()
        {
            var webDataContext = _context.NhanViens.Include(n => n.IdBaoCaoNavigation).Include(n => n.IdChucVuNavigation).Include(n => n.IdPnhNavigation).Include(n => n.IdPxhNavigation).Include(n => n.IdThongBaoNavigation);
            return View(await webDataContext.ToListAsync());
        }

        // GET: NhanViens/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanViens
                .Include(n => n.IdBaoCaoNavigation)
                .Include(n => n.IdChucVuNavigation)
                .Include(n => n.IdPnhNavigation)
                .Include(n => n.IdPxhNavigation)
                .Include(n => n.IdThongBaoNavigation)
                .FirstOrDefaultAsync(m => m.IdNv == id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            return View(nhanVien);
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
        // GET: NhanViens/Create
        public IActionResult Create()
        {
            NhanVien nv = new NhanVien();
            nv.IdNv = "nv" + codeRandom();
            nv.IdBaoCao = null;
            nv.IdPnh = null;
            nv.IdPxh = null;
            nv.IdThongBao = null;
            ViewData["IdChucVu"] = new SelectList(_context.ChucVus, "IdChucVu", "IdChucVu");
            return View(nv);
        }

        // POST: NhanViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNv,HoTenNv,Email,Sdt,DiaChi,MatKhau,IdChucVu,IdPnh,IdPxh,IdBaoCao,IdThongBao")] NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhanVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdBaoCao"] = new SelectList(_context.BaoCaos, "IdBaoCao", "IdBaoCao", nhanVien.IdBaoCao);
            ViewData["IdChucVu"] = new SelectList(_context.ChucVus, "IdChucVu", "IdChucVu", nhanVien.IdChucVu);
            ViewData["IdPnh"] = new SelectList(_context.PhieuNhaps, "IdPnh", "IdPnh", nhanVien.IdPnh);
            ViewData["IdPxh"] = new SelectList(_context.PhieuXuats, "IdPxh", "IdPxh", nhanVien.IdPxh);
            ViewData["IdThongBao"] = new SelectList(_context.ThongBaos, "IdThongBao", "IdThongBao", nhanVien.IdThongBao);
            return View(nhanVien);
        }

        // GET: NhanViens/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanViens.FindAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            ViewData["IdBaoCao"] = new SelectList(_context.BaoCaos, "IdBaoCao", "IdBaoCao", nhanVien.IdBaoCao);
            ViewData["IdChucVu"] = new SelectList(_context.ChucVus, "IdChucVu", "IdChucVu", nhanVien.IdChucVu);
            ViewData["IdPnh"] = new SelectList(_context.PhieuNhaps, "IdPnh", "IdPnh", nhanVien.IdPnh);
            ViewData["IdPxh"] = new SelectList(_context.PhieuXuats, "IdPxh", "IdPxh", nhanVien.IdPxh);
            ViewData["IdThongBao"] = new SelectList(_context.ThongBaos, "IdThongBao", "IdThongBao", nhanVien.IdThongBao);
            return View(nhanVien);
        }

        // POST: NhanViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdNv,HoTenNv,Email,Sdt,DiaChi,MatKhau,IdChucVu,IdPnh,IdPxh,IdBaoCao,IdThongBao")] NhanVien nhanVien)
        {
            if (id != nhanVien.IdNv)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhanVien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhanVienExists(nhanVien.IdNv))
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
            ViewData["IdBaoCao"] = new SelectList(_context.BaoCaos, "IdBaoCao", "IdBaoCao", nhanVien.IdBaoCao);
            ViewData["IdChucVu"] = new SelectList(_context.ChucVus, "IdChucVu", "IdChucVu", nhanVien.IdChucVu);
            ViewData["IdPnh"] = new SelectList(_context.PhieuNhaps, "IdPnh", "IdPnh", nhanVien.IdPnh);
            ViewData["IdPxh"] = new SelectList(_context.PhieuXuats, "IdPxh", "IdPxh", nhanVien.IdPxh);
            ViewData["IdThongBao"] = new SelectList(_context.ThongBaos, "IdThongBao", "IdThongBao", nhanVien.IdThongBao);
            return View(nhanVien);
        }

        // GET: NhanViens/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanViens
                .Include(n => n.IdBaoCaoNavigation)
                .Include(n => n.IdChucVuNavigation)
                .Include(n => n.IdPnhNavigation)
                .Include(n => n.IdPxhNavigation)
                .Include(n => n.IdThongBaoNavigation)
                .FirstOrDefaultAsync(m => m.IdNv == id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            return View(nhanVien);
        }

        // POST: NhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nhanVien = await _context.NhanViens.FindAsync(id);
            if (nhanVien != null)
            {
                _context.NhanViens.Remove(nhanVien);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhanVienExists(string id)
        {
            return _context.NhanViens.Any(e => e.IdNv == id);
        }
    }
}
