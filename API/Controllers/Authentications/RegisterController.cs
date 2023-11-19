using Microsoft.AspNetCore.Mvc;
using WeatherCheckApi.Application.Constants;
using WeatherCheckApi.Application.DTO;
using WeatherCheckApi.Interfaces;
using WeatherCheckApi.Responses;

namespace WeatherCheckApi.Controllers.Authentications
{
    [Route("api/register")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IAuthServiceAdapter _authService;

        public RegisterController(IAuthServiceAdapter authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserDto user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            bool isRegistered = await _authService.Register(user);

            if (!isRegistered) return BadRequest(new { error = MessageConstants.UserAlreadyRegistered });

            return Ok(new SuccessResponse(MessageConstants.RegistrationSuccess));

        }
    }
}
