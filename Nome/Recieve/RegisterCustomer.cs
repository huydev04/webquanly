using System.ComponentModel.DataAnnotations;

namespace Nome.Recieve
{
    public class RegisterCustomer
    {
        [Required]
        [Display(Name = "Họ và tên")]
        public string HoTenKh { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày sinh")]
        public DateOnly NgaySinh { get; set; }

        [Required]
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email không hợp lệ!")]
        public string? Email { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Số điện thoại")]
        public string Std { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Mật khẩu tối thiểu 6 ký tự")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }
    }
}
