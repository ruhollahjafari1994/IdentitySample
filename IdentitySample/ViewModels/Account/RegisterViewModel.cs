using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySample.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name ="نام کاربری")]
        public string UserName { get; set; }


        [Required]
        [Display(Name = "ایمیل")]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [Display(Name = "رمز عبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        

        [Required]
        [Display(Name = "تکرار رمز عبور")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))] // => Compare password and ConfirmPassword
        public string ConfirmPassword { get; set; }
    }
}
