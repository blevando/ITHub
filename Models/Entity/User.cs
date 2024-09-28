using Microsoft.AspNetCore.Identity;

namespace ITHub.Models.Entity
{
    public class User : IdentityUser
    {
        public string? Region { get; set; }

    }
}
