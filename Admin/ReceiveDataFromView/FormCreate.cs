using Admin.Models;

namespace Admin.ReceiveDataFromView
{
    public class FormCreate
    {
        public SanPham sp = new SanPham();
        public IFormFile formFile { get; set; }
        public NhomThuoc nhomThuoc = new NhomThuoc();
        public NhaCungCap NhaCungCap { get; set; }
        public List<NhomThuoc> listNhomThuoc;
        public List<NhaCungCap> listNhaCungCap;
    }
}
