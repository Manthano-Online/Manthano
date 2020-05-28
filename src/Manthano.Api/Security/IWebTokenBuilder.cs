using Manthano.Data.Models;

namespace Manthano.Api.Security
{
    public interface IWebTokenBuilder
    {
        string GenerateToken(User user);
    }
}
