using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppMVC5.Models.EF
{
    public class Student
    {
        [Required(ErrorMessage = "ID không được để trống!")]
        [StringLength(10, ErrorMessage = "ID là một chuỗi có độ dài 10 ký tự!")]
        public string Id { get; set; }
        [Required(ErrorMessage = "Họ tên không được để trống!")]
        [MaxLength(50, ErrorMessage = "Họ tên không quá 50 ký tự!")]

        public string FullName { get; set; }

        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "EMail không được để trống!")]
        [EmailAddress]
        public string Email { get; set; }

        [Compare(nameof(Email), ErrorMessage = "Nhập lại Email không đúng!")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống!")]
        [MaxLength(15, ErrorMessage = "Số điện thoại không quá 15 ký tự")]
        [RegularExpression("(84|0[3|5|7|8|9])+([0-9]{8})\b", ErrorMessage = "Số điện thoại không đúng định dạng")]
        public string PhoneNumber { get; set; }
        public string IDCard { get; set; }
    }
}