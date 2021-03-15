using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWebApp.Shared
{
    public class ProfileRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(16, ErrorMessage = "Username too long")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Range(typeof(bool), "true", "true", ErrorMessage = "You have to confirm your profile")]
        public bool isConfirmed { get; set; } = true;
    }
}
