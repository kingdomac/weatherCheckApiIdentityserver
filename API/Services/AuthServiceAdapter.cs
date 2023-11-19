using System.Net.Http;
using WeatherCheckApi.Application.DTO;
using WeatherCheckApi.Interfaces;

namespace WeatherCheckApi.Services
{
    public class AuthServiceAdapter : IAuthServiceAdapter
    {
       private readonly IAuthIndentityServerServiceProvider _identityServerServiceProvider;

        public AuthServiceAdapter(IAuthIndentityServerServiceProvider identityServerServiceProvider)
        {
            _identityServerServiceProvider = identityServerServiceProvider;
        }

        public async Task<bool> Register(RegisterUserDto user)
        {
            bool isRegistered = await _identityServerServiceProvider.Register(user);

            if(!isRegistered) return false;

            return true;
        }

        public async Task<string> Login(LoginUserDto loginUserDto)
        {
            string loginResult = await _identityServerServiceProvider.Login(loginUserDto);

            return loginResult;
        }
    }
}
