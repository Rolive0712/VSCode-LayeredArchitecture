using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreApp.UI.Controllers
{
    // JWT in Intranet Environment.
    //https://stackoverflow.com/questions/27217424/use-windows-authentication-with-oauth-2-0

    //check below link to use asp.net identity with .net core
    //http://docs.identityserver.io/en/release/quickstarts/6_aspnet_identity.html

    // [RoutePrefix("token/windows")]
    // public class WindowsAuthenticationController: ApiController
    // {
    //     [Authorize]
    //     [HttpPost]
    //     [Route("{client_id}"]
    //     public async Task<IHttpActionResult> CreateTokenForWindowsIdentity(string client_id)
    //     {
    //         var user = User as ClaimsPrincipal;
    //         if (user == null) return Unauthorized(); //401
    //         var claims = //generate claims based on the User.Identity.Name...
    //         var identity = new ClaimsIdentity("JWT");
    //         identity.AddClaims(claims);

    //         //manually create JWT using whatever method you prefer,
    //         //I used something inspired from http://bitoftech.net/2015/02/16/implement-oauth-json-web-tokens-authentication-in-asp-net-web-api-and-identity-2/
    //     }
    // }

    // also check link below
    //https://pioneercode.com/post/authentication-in-an-asp-dot-net-core-api-part-3-json-web-token
}