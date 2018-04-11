using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdpStore.Controllers
{
    [Route("Contact")]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public bool AddMessage(string message)
        {
            return false;
        }
    }
}