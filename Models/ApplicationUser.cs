using Microsoft.AspNetCore.Identity;

namespace LoginRegister_MateoVelasquez.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }

        public string? UserNames {  get; set; }

    }
}