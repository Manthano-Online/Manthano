using Microsoft.AspNetCore.Identity;

namespace Manthano.Data.Models
{
    public class AppRole : IdentityRole<int>
    {
        public AppRole() { }

        public AppRole(string roleName) : base(roleName) { }
    }
}
