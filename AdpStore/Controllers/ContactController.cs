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
        [HttpGet()]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost()]
        public IActionResult AddMessage()
        {
            return View("Index");
        }
    }
}