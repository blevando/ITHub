using System.ComponentModel.DataAnnotations;

namespace ITHub.Models.Dto
{
    public class LoginRequestDto
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
