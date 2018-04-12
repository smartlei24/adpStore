using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Biz;
using AdpStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdpStore.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        private IUserBiz biz;

        public LoginController(IUserBiz biz)
        {
            this.biz = biz;
        }

        public IActionResult Login(User user)
        {
            var isExist = this.biz.CheckUserIsExist(user);
            return View("Index", user);
        }
    }
}