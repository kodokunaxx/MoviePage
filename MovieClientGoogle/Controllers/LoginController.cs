using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MovieClient.Controllers
{
    public class LoginController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;

        public LoginController(UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
        }
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult GoogleLogin()
        {
            string redirectUrl = Url.Action("GoogleResponse", "Login");
            var properties = signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);
            return new ChallengeResult("Google", properties);
        }

        [AllowAnonymous]
        public async Task<IActionResult> GoogleResponse()
        {
            ExternalLoginInfo info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
                return RedirectToAction("", "login");

            //var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider , info.ProviderKey , true);
            string[] userInfo =
            {
                info.Principal.FindFirst(ClaimTypes.Name).Value,
                info.Principal.FindFirst(ClaimTypes.Email).Value
            };
            var checker = await userManager.FindByEmailAsync(userInfo[1]);

            IdentityUser user = new IdentityUser()
            {
                Email = userInfo[1],
                EmailConfirmed = true,
                UserName = userInfo[1]
            };

            if (checker != null)
            {
                user = checker;
            }
            else
            {
                var identityResult = await userManager.CreateAsync(user);
                if (!identityResult.Succeeded)
                {
                    TempData["Failure"] = "Account Not Found";
                    return RedirectToAction("", "login");
                }
            }
            var roles = await userManager.GetRolesAsync(user);
            var claims = new[]
            {
                        new Claim(ClaimTypes.Email,user.Email),
                        new Claim(ClaimTypes.GivenName,user.Email),
                        new Claim(ClaimTypes.Role, string.Join(";",roles)),
                        new Claim(ClaimTypes.Name, user.UserName)
                    };
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(5),
                IsPersistent = true
            };
            await signInManager.SignInAsync(user, authProperties);
            return RedirectToAction("", "home");
        }
    }
}
