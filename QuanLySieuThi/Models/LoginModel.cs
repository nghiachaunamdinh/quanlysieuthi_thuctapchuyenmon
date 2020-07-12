using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySieuThi.Models
{
    public class LoginModel
    {
        [Key]
        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage = "Bạn phải nhập tên tài khoản")]
        public string Username { set; get; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Bạn phải nhập mật khẩu")]
        public string Password { set; get; }
    }
}
