using HotChocolate.AspNetCore.Subscriptions.Messages;
using HotChocolate.AspNetCore.Subscriptions;
using HotChocolate.AspNetCore;
using HotChocolate.Execution;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Principal;
using System.Text;

namespace DevInCar.API.Models
{
    public class ValidateToken
    {
        public static class ValidateJWT
        {
            public static bool ValidateToken(string authToken)
            {
                var key = "111b9a919ce434e9fd8423a24b2025ffddcb964a0ae1625d10ada390";
                var tokenHandler = new JwtSecurityTokenHandler();
                var validationParameters = new TokenValidationParameters
                {
                    ValidIssuer = "localhost:7044",
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidAudience = "Devincar",
                    IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(key)
                ),
                };

                SecurityToken validatedToken;
                try
                {
                    IPrincipal principal = tokenHandler.ValidateToken(authToken, validationParameters, out validatedToken);
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
