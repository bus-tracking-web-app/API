using First.CORE.DATA;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace First.INFRA.SERVICE
{
    public class JWTService : IJWTService
    {
        private readonly IJWTRepository _jwtRepository;

        public JWTService(IJWTRepository jwtRepository)
        {
            _jwtRepository = jwtRepository;
        }
        public string Auth(User user)
        {
            var result = _jwtRepository.Auth(user);
            if (result == null)
            {
                return null;
            }
            else
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()),
                new Claim(ClaimTypes.Role, result.Roleid.ToString())
            };
                var tokeOptions = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddHours(3),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return tokenString;

            }
        }
    }
}
