using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Banking.Model
{
    public class UserLogin : IdentityUser
    {
        [Required]
        [MaxLength(50)]
        public string UserNameBanking { get; set; }
        [Required]
        [MaxLength(15)]
        public string Password { get; set; }
    }
}
