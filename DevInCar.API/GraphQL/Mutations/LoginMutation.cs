using DevInCar.API.DTOs;
using DevInCar.API.Models;
using DevInCar.API.Repositories;
using DevInCar.API.Services;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace DevInCar.API.GraphQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]

    public class LoginMutation
    {
        [GraphQLName("User_login")]
        public string UserLogin([Service] IOptions<TokenSettings> tokenSettings,
        [Service] IUserService service,
        LoginDTO login)
        {
            var currentUser = service.AuthenticateUser(login);
            if (currentUser != null)
            {
                var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSettings.Value.Key));
                var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);

                var jwtToken = new JwtSecurityToken(
                    issuer: tokenSettings.Value.Issuer,
                    audience: tokenSettings.Value.Audience,
                    signingCredentials: credentials,
                    expires: DateTime.Now.AddHours(6)
                );

                string token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
                return token;

            }
            return string.Empty;
        }
    }
}
