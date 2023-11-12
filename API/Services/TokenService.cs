using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace API.Services
{
    public class TokenService
    {
        private const int ExpirationMinutes = 30;
        private const string JwtAlgorithm = SecurityAlgorithms.HmacSha256Signature;
        private const string JwtIssuer = "apiWithTravelooIdentityToken";

        public string CreateToken(IdentityUser user)
        {
            var expiration = DateTime.UtcNow.AddMinutes(ExpirationMinutes);
            var token = CreateJwtToken(
                CreateClaims(user),
                CreateSigningCredentials(),
                expiration
            );
            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }

        private JwtSecurityToken CreateJwtToken(List<Claim> claims,
            SigningCredentials credentials,
            DateTime expiration) =>
                new JwtSecurityToken(
                    JwtIssuer,
                    JwtIssuer,
                    claims,
                    expires: expiration,
                    signingCredentials: credentials
                );

        private List<Claim> CreateClaims(IdentityUser user)
        {
            return new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToString(CultureInfo.InvariantCulture)),
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email)
            };
        }

        private SigningCredentials CreateSigningCredentials() =>
            new SigningCredentials(
                new SymmetricSecurityKey(GenerateRandomKey(32)),
                JwtAlgorithm
            );

        private byte[] GenerateRandomKey(int length)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var key = new byte[length];
                rng.GetBytes(key);
                return key;
            }
        }

        //private const int ExpirationMinutes = 30;
        //public string CreateToken(IdentityUser user)
        //{
        //    var expiration = DateTime.UtcNow.AddMinutes(ExpirationMinutes);
        //    var token = CreateJwtToken(
        //        CreateClaims(user),
        //        CreateSigningCredentials(),
        //        expiration
        //    );
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    return tokenHandler.WriteToken(token);
        //}

        //private JwtSecurityToken CreateJwtToken(List<Claim> claims, SigningCredentials credentials,
        //    DateTime expiration) =>
        //    new(
        //        "apiWithAuthBackend",
        //        "apiWithAuthBackend",
        //        claims,
        //        expires: expiration,
        //        signingCredentials: credentials
        //    );

        //private List<Claim> CreateClaims(IdentityUser user)
        //{
        //    try
        //    {
        //        var claims = new List<Claim>
        //        {
        //            new Claim(JwtRegisteredClaimNames.Sub, "TokenForTheApiWithAuth"),
        //            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //            new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString(CultureInfo.InvariantCulture)),
        //            new Claim(ClaimTypes.NameIdentifier, user.Id),
        //            new Claim(ClaimTypes.Name, user.UserName),
        //            new Claim(ClaimTypes.Email, user.Email)
        //        };
        //        return claims;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //}
        //private SigningCredentials CreateSigningCredentials()
        //{
        //    return new SigningCredentials(
        //        new SymmetricSecurityKey(
        //            Encoding.UTF8.GetBytes("!SomethingSecret!")
        //        ),
        //        SecurityAlgorithms.HmacSha256
        //    );
        //}
    }
}
