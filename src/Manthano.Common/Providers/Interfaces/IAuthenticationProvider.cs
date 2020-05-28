using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manthano.Common.Models;
using Manthano.Data.Models;

namespace Manthano.Common.Providers.Interfaces
{
    public interface IAuthenticationProvider
    {
        Task<User> Login(LoginModel model);
    }
}
