using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Biz;
using AdpStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdpStore.Controllers
{
    [Route("register")]
    public class RegisterController : Controller
    {
        private IUserBiz biz;

        public RegisterController(IUserBiz biz)
        {
            this.biz = biz;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost()]
        public async Task<IActionResult> RigisterNewUser(User newUser)
        {
            var user = this.biz.AddNewUser(newUser);
            return View("Index", user);
        }
    }
}