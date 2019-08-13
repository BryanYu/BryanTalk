using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using TalkServer.Modals;

namespace TalkServer.Controllers
{
    [Route("api/[controller]")]
    public class TokenController : Controller
    {
        private readonly IConfiguration _config;

        public TokenController(IConfiguration config)
        {
            _config = config;
        }
        public IActionResult Token([FromBody] LoginModel login)
        {
            if (login.Account != "Bryan" && login.Password != "123")
            {
                return Unauthorized();
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
            {
                new Claim("rol", "Admin"),
                new Claim("nam", login.Account)
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Issuer"],
                expires: DateTime.Now.AddMinutes(30), claims: claims, signingCredentials: credential);
            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)
            });

        }

    }
}
