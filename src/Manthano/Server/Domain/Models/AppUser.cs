using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manthano.Domain.Models;

public class AppUser : IdentityUser<int>
{
    public AppUser() { }

    public AppUser(string email, string firstName, string lastName, string password)
    {
        UserName = Email = email;
        NormalizedUserName = NormalizedEmail = email.ToUpper();
        FirstName = firstName;
        LastName = lastName;
        IsActive = true;
        LockoutEnabled = false;
        EmailConfirmed = true;
        SecurityStamp = System.Guid.NewGuid().ToString();
        PasswordHash = new PasswordHasher<AppUser>().HashPassword(this, password);
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? ChurchId { get; set; }
    public bool IsActive { get; set; }

    public Church Church { get; set; }
    public List<Group> Groups { get; set; }
    public List<BibleReadThrough> ReadThroughs { get; set; }
    public List<Goal> Goals { get; set; }
    public List<Book> Books { get; set; }
    public List<BookReadThrough> BookReadThroughs { get; set; }
    public UserSettings UserSettings { get; set; }
    public List<BibleTranslation> BibleTranslations { get; set; }


    [NotMapped]
    public string FullName => $"{FirstName} {LastName}";

}
