using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SkiServiceManagement.Models
{
    public class TokenRefreshRequest
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
