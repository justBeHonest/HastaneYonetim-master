using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.Core.ViewModel
{
    public class RegisterViewModel
    {
        [Display(Name ="İsim")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Parolayı Doğrula")]
        [Compare("Password", ErrorMessage = "Parolalar Uyumsuz.")]
        public string ConfirmPassword { get; set; }

        public bool? IsActive { get; set; }

    }
}