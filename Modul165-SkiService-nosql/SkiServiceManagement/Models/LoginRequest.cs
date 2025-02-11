using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SkiServiceManagement.Models
{
    public class LoginRequest
    {
        [Required]
        [MaxLength(50)]
        public string Benutzername { get; set; }

        [Required]
        [MaxLength(100)]
        public string Passwort { get; set; }
    }
}
