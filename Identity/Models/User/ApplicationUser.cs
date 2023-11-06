using Microsoft.AspNetCore.Identity;

namespace API.Entities.User
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
