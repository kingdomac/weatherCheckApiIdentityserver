﻿using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WeatherCheckApi.Application.DTO;
using WeatherCheckApi.Interfaces;

namespace WeatherCheckApi.Services
{
    public class AuthServiceProvider : IAuthServiceProvider
    {
        
        private readonly IConfiguration _config;

        public AuthServiceProvider(IConfiguration config)
        {
            _config = config;
        }

        //public async Task<bool> Register(RegisterUserDto user)
        //{
            
        //    var identityUser = new IdentityUser
        //    {
        //        UserName = user.Email,
        //        Email = user.Email
        //    };

        //    var result = await _userManager.CreateAsync(identityUser, user.Password);

        //    return result.Succeeded;
        //}

        //public async Task<(IdentityUser identityUser, bool success)> Login(LoginUserDto user)
        //{

        //    var identityUser = await _userManager.FindByEmailAsync(user.Email);
        //    if (identityUser is null)
        //    {
        //        return (new IdentityUser(), false);
        //    }

        //    var isPasswordValid = await _userManager.CheckPasswordAsync(identityUser, user.Password);
        //    if (!isPasswordValid)
        //    {
        //        return (new IdentityUser(), false);
        //    }

        //    return (identityUser, isPasswordValid);
        //}

        //public string GenerateTokenString(IdentityUser user)
        //{
        //    IEnumerable<Claim> claims = new List<Claim>
        //    {
        //        new Claim(ClaimTypes.NameIdentifier, user.Id),
        //        new Claim(ClaimTypes.Email, user.Email),
        //    };

        //    var securityKey = new SymmetricSecurityKey(
        //        Encoding.UTF8.GetBytes(_config.GetSection("Jwt:Key").Value));

        //    SigningCredentials signingCred = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);

        //    var securityToken = new JwtSecurityToken(
        //        claims: claims,
        //        expires: DateTime.Now.AddMinutes(60),
        //        issuer: _config.GetSection("Jwt:Issuer").Value,
        //        audience: _config.GetSection("Jwt:Audience").Value,
        //        signingCredentials: signingCred
        //        );
        //    string tokenString = new JwtSecurityTokenHandler().WriteToken(securityToken);
        //    return tokenString;
        //}

        //public async Task<bool> CheckIfUserAlreadyxist(RegisterUserDto user)
        //{
        //    var userDb =  await _userManager.FindByEmailAsync(user.Email);

        //    if (userDb is not null) return true;

        //    return false;
            
        //}
    }
}
