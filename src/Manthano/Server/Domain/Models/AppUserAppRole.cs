using Microsoft.AspNetCore.Identity;

namespace Manthano.Domain.Models;

public class AppUserAppRole : IdentityUserRole<int>
{
    public AppUser User { get; set; }
    public AppRole Role { get; set; }
}
