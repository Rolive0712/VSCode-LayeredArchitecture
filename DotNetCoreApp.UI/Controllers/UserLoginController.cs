using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace DotNetCoreApp.UI.Controllers
{
    public class UserLoginController : Controller
    {
        
    }

    // [AllowAnonymous]
    // [HttpPost]
    // [Route("token")]
    // public IActionResult Post([FromBody]LoginViewModel loginViewModel)
    //     {
    //     if (ModelState.IsValid)
    //     {
    //         //This method returns user id from username and password.
    //         var userId = GetUserIdFromCredentials(loginViewModel); 
    //         if (userId == -1)
    //         {
    //             return Unauthorized();
    //         }

    //         var claims = new[]
    //         {
    //             new Claim(JwtRegisteredClaimNames.Sub, loginViewModel.Username),
    //             new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    //         };

    //         var token = new JwtSecurityToken
    //         (
    //             issuer: _configuration["Issuer"],
    //             audience: _configuration["Audience"],
    //             claims: claims,
    //             expires: DateTime.UtcNow.AddDays(60),
    //             notBefore: DateTime.UtcNow,
    //             signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SigningKey"])),
    //                     SecurityAlgorithms.HmacSha256)
    //         );

    //         return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
    //     }

    //     return BadRequest();
    // }
}