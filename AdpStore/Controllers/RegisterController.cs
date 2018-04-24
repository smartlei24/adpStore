using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Biz;
using AdpStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdpStore.Controllers
{
    [Route("register/")]
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

        [Route("new")]
        public IActionResult RigisterNewUser(User newUser)
        {
            if (string.IsNullOrWhiteSpace(newUser.Name))
            {
                ModelState.AddModelError("", "用户名为不能为空");
                return View("Index");
            }

            if (string.IsNullOrWhiteSpace(newUser.Password))
            {
                ModelState.AddModelError("", "密码为不能为空");
                return View("Index");
            }

            if (string.IsNullOrWhiteSpace((newUser.EmailAddress)))
            {
                ModelState.AddModelError("", "邮件地址不能为空");
                return View("Index");
            }

            if (string.IsNullOrWhiteSpace((newUser.TelNumber)))
            {
                ModelState.AddModelError("", "电话号码不能为空");
                return View("Index");
            }

            if (string.IsNullOrWhiteSpace((newUser.Address)))
            {
                ModelState.AddModelError("", "地址不能为空");
                return View("Index");
            }

            var isSuccess = this.biz.AddNewUser(newUser);
            if (!isSuccess)
            {
                ModelState.AddModelError("", "用户名已存在，请尝试其他用户名");
                return View("Index");
            }
            return Redirect("/login");
        }
    }
}