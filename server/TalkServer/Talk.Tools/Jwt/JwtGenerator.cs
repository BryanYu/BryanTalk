using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Talk.Tools
{
    public class JwtGenerator
    {
        ///  <summary>
        ///
        ///  </summary>
        /// <param name="issuer"></param>
        /// <param name="audience"></param>
        /// <param name="secretKey"></param>
        /// <param name="securityAlgorithms"></param>
        /// <param name="claims"></param>
        /// <param name="expiredMinute"></param>
        /// <returns></returns>
        public static string GeneratorToken(string issuer, string audience, string secretKey, string securityAlgorithms, List<Claim> claims, int expiredMinute = 30)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var credential = new SigningCredentials(key, securityAlgorithms);

            var token = new JwtSecurityToken(issuer, audience,
                expires: DateTime.Now.AddMinutes(expiredMinute), claims: claims, signingCredentials: credential);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}