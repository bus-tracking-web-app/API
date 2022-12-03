using First.CORE.DATA;
using First.CORE.REPOSITORY;
using First.CORE.SERVICE;
using Microsoft.IdentityModel.Tokens;
using System;
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
        /*
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
                new Claim(ClaimTypes.Name, result.Username),
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
        */
        public string Auth(User user)
        {
            //return jwtRepository.Auth(login); ---> useranme & rolename(payload)
            var result = _jwtRepository.Auth(user);//result = useraname & rolename

            if (result == null)
                return null;
            else
            {
                // Generate Token
                // 1- Token Handler --> Class (Create Token)
                var TokenHandler = new JwtSecurityTokenHandler();

                // 2- Token Key --> The same as key in the startup
                var TokenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SECRET USED TO SIGN AND VERIFY JWT TOKEN"));

                // 3- Token Descriptor --> Paylod (result) + prop
                var TokenDescriptor = new SecurityTokenDescriptor
                {
                    // Subject
                    Subject = new ClaimsIdentity(new Claim[]
                    {

                        // new Claim(type, value)
                        new Claim(ClaimTypes.Name, result.Username),
                        // new Claim(type, value)
                        new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()),
                        // new Claim(type, value)
                        new Claim(ClaimTypes.Role, result.Roleid.ToString())
                    }),

                    // Expires
                    Expires = DateTime.UtcNow.AddHours(1),

                    // Signing Credintials

                    SigningCredentials = new SigningCredentials(TokenKey, SecurityAlgorithms.HmacSha256Signature)
                };

                var token = TokenHandler.CreateToken(TokenDescriptor);
                return TokenHandler.WriteToken(token); // string
            }
        }
    }

}

