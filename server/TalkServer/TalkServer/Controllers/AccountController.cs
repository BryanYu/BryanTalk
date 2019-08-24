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
using Talk.Models.Account;
using Talk.Service.Implements;
using Talk.Service.Interfaces;
using Talk.Tools;

namespace TalkServer.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        private readonly IConfiguration _config;

        public AccountController(IUserService userService, IConfiguration config)
        {
            _userService = userService;
            _config = config;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody] LoginModel login)
        {
            if (!this._userService.Verify(login.Account, login.Password))
            {
                return Unauthorized();
            }

            var claims = new List<Claim>
            {
                new Claim("rol", "Admin"),
                new Claim("nam", login.Account)
            };
            var token = JwtGenerator.GeneratorToken(_config["Jwt:Issuer"], _config["Jwt:Issuer"], _config["Jwt:Key"],
                SecurityAlgorithms.HmacSha256, claims, 30);

            return Ok(
                new
                {
                    token = token
                });
        }

        [HttpPost]
        public IActionResult Register([FromBody] RegisterModel register)
        {
            this._userService.Register(register);
            return Ok();
        }
    }
}