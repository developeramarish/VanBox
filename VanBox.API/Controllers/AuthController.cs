using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using VanBox.API.Contracts;
using VanBox.API.DTOs;
using VanBox.API.Models;

namespace VanBox.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository Repository;
        private readonly IConfiguration Config;
        public AuthController(IAuthRepository repo, IConfiguration config)
        {
            this.Config = config;
            this.Repository = repo;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserDTO userDTO) // [FromBody] if not APIController not added
        {
            // validation

            // (ModelState.IsValid) if not APIController not added

            userDTO.Name = userDTO.Name.ToLower();

            if (await Repository.UserExist(userDTO.Name))
                return BadRequest("User Exists");

            var user = new User
            {
                Name = userDTO.Name
            };

            var createdUser = await Repository.Register(user, userDTO.Password);
            return StatusCode(201);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDTO userDto)
        {            
            var user = await Repository.Login(userDto.Name.ToLower(), userDto.Password);

            if (user == null)
                return Unauthorized();

            var claim = new[]{
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key,SecurityAlgorithms.HmacSha512);

            var tokenDescription = new SecurityTokenDescriptor{
                Subject = new ClaimsIdentity(claim),
                Expires = DateTime.Now.AddMinutes(600),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var toke = tokenHandler.CreateToken(tokenDescription);

            return Ok(new{
                token = tokenHandler.WriteToken(toke)
            });

        }

    }
}