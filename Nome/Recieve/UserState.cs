using Nome.Models;

namespace Nome.Recieve
{
    public class UserState
    {
        public static List<KhachHang> statelogin = new List<KhachHang>();
        public static List<OrderProduct> stateCart = new List<OrderProduct>();
        public static KhachHang UserLog()
        {
            KhachHang khachHang = new KhachHang();
            foreach (var hang in statelogin)
            {
                khachHang.IdKh = hang.IdKh;
                khachHang.HoTenKh = hang.HoTenKh;
                khachHang.NgaySinh = hang.NgaySinh;
                khachHang.Email = hang.Email;
                khachHang.DiaChi = hang.DiaChi;
                khachHang.MatKhau = hang.MatKhau;
                khachHang.IdGioHang = hang.IdGioHang;
                khachHang.IdDonHang = hang.IdDonHang;
                khachHang.TichDiem = hang.TichDiem;
                khachHang.GiayPhep = hang.GiayPhep;
                khachHang.Std = hang.Std;
                khachHang.LoaiKh = hang.LoaiKh;
            }
            return khachHang;
        }
    }
}
