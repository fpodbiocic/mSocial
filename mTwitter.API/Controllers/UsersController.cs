using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using mTwitter.API.Models;
using mTwitter.API.Helpers;
using mTwitter.API.Services;
using System.IdentityModel.Tokens.Jwt;
using mTwitter.API.Helpers;
using static mTwitter.API.Models.UserModel;

namespace mTwitter.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly AppsettingsJson _appSettings;

        public UsersController(IUserService userService, IOptions<AppsettingsJson> appSettings)
        {
            _userService = userService;
            _appSettings = appSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody] UserPostRegDTO newUser)
        {
            if(newUser == null)
            {
                return BadRequest();
            }

            try
            {
                // save
                UserDTO udto =_userService.CreateNewUser(newUser.FirstName, newUser.LastName, newUser.Email, newUser.Password, newUser.PhoneNumber);
                return Ok(udto);
            }
            catch(ApplicationException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserPostAuthDTO user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            UserDTO udto = _userService.Authenticate(user.Email, user.Password);

            if (udto == null)
            {
                return BadRequest(new { message = "Email or password is incorrect" });
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, udto.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            udto.Token = tokenString;

            return Ok(udto);
        }
    }
}