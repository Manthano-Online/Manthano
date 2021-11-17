using Microsoft.AspNetCore.Identity;

namespace Manthano.Domain.Models;

public class AppRole : IdentityRole<int>
{
    public List<AppUserAppRole> UserRoles { get; set; }
}
