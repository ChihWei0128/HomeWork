using HomeWork.ValidateAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "帳號")]
        //[DataType(DataType.EmailAddress)]
        //[RegularExpression(@"\w.+\@\w.+")]
        [Email(ErrorMessage = "帳號必須為Email格式")]
        [NoIs("skilltree,demo,twMVC", ErrorMessage = "帳號內有不可使用的字串[skilltree, demo, twMVC]")]
        public string Account { get; set; }

        [Required]
        [Display(Name = "密碼")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 4)]
        public string Password { get; set; }

        public string Message { get; set; }
    }
}