using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SkiServiceManagement.Models
{
    public class Benutzer
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Vorname { get; set; }

        [StringLength(50)]
        public string Nachname { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Benutzername { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Passwort { get; set; }

        [Required]
        [MaxLength(20)]
        public string Rolle { get; set; } = "Kunde"; // Standardrolle ist Kunde

        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiry { get; set; }

    }
}
