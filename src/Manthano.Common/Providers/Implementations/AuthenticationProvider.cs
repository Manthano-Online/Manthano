using System.Threading.Tasks;
using Manthano.Common.Extensions;
using Manthano.Common.Models;
using Manthano.Common.Providers.Interfaces;
using Manthano.Data.EntityFramework.Models;
using Manthano.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Manthano.Common.Providers.Implementations
{
    internal class AuthenticationProvider : IAuthenticationProvider
    {
        private readonly UserManager<AppUser> _userManager;

        public AuthenticationProvider(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<User> Login(LoginModel model)
        {
            Require.ThatNotNull(model, nameof(model));

            var dbUser = await _userManager.FindByEmailAsync(model.Email);
            if (dbUser == null)
            {
                return null;
            }

            if (await _userManager.CheckPasswordAsync(dbUser, model.Password))
            {
                return new User(dbUser.Id, dbUser.FirstName, dbUser.LastName, dbUser.Email, dbUser.UserName);
            }

            return null;
        }
    }
}
