using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdpStore.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/Error")]
        public IActionResult Index()
        {
            return View("404");
        }
    }
}