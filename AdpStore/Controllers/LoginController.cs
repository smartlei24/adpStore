using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AdpStore.Biz;
using AdpStore.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace AdpStore.Controllers
{
    [Route("login")]
    public class LoginController : Controller
    {
        private IUserBiz biz;

        public LoginController(IUserBiz biz)
        {
            this.biz = biz;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        public IActionResult Login(User user)
        {
            var isExist = this.biz.CheckUserIsExist(user);
            if (isExist)
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Sid, user.ID.ToString()));
                identity.AddClaim(new Claim(ClaimTypes.Name, user.Name));
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));
                return Redirect("/");
            }
            else
            {
                ModelState.AddModelError("", "用户名或密码错误");
                return View("Index");
            }
        }

        private bool hasLoggedIn()
        {
            return !string.IsNullOrWhiteSpace(User.Identity.Name);
        }

        [Route("logout")]
        public IActionResult Logout(User user)
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/");
        }
    }
}