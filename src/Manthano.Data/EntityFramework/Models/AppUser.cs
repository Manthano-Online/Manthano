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

        public static AppUser SeedNewUser(string username, string firstName, string lastName, string email, string password)
        {
            var appUser = new AppUser(username, null, null, null)
            {
                Email = email,
                NormalizedEmail = email.ToUpper(),
                UserName = username,
                NormalizedUserName = username.ToUpper(),
                FirstName = firstName,
                LastName = lastName,
                LockoutEnabled = false,
                EmailConfirmed = true,
                SecurityStamp = System.Guid.NewGuid().ToString(),
            };
            appUser.PasswordHash = new PasswordHasher<AppUser>().HashPassword(appUser, password);
            return appUser;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
