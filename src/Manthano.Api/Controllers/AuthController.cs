using System.Threading.Tasks;
using Manthano.Api.Security;
using Manthano.Common.Models;
using Manthano.Common.Providers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Manthano.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IWebTokenBuilder _webTokenBuilder;
        private readonly IAuthenticationProvider _authenticationProvider;
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger, IWebTokenBuilder webTokenBuilder, IAuthenticationProvider authenticationProvider)
        {
            _logger = logger;
            _webTokenBuilder = webTokenBuilder;
            _authenticationProvider = authenticationProvider;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid model for user: ${model?.Email} and password with length ${model?.Password?.Length ?? 0}");
                return BadRequest(ModelState);
            }

            var user = await _authenticationProvider.Login(model);

            if (user == null)
            {
                _logger.LogError($"User not found for user: ${model?.Email} and password with length ${model?.Password?.Length ?? 0}");
                return BadRequest();
            }

            var token = _webTokenBuilder.GenerateToken(user);
            return Ok(new { user.FirstName, user.LastName, Token = token });
        }
    }
}
