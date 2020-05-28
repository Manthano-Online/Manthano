using Microsoft.AspNetCore.Identity;

namespace Manthano.Data.EntityFramework.Models
{
    public class AppUser : IdentityUser<int>
    {
        public AppUser() { }

        public AppUser(string userName, string firstName, string lastName, string email) : base(userName)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
