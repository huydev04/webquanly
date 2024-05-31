using System.ComponentModel.DataAnnotations;

namespace Nome.Recieve
{
    public class LoginCustomer
    {
        [Required]
        [EmailAddress(ErrorMessage = "Email không hợp lệ!")]
        public string? Email { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Mật khẩu tối thiểu 6 ký tự")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }
    }
}
