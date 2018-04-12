using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdpStore.Models;
using AdpStore.Biz;

namespace AdpStore.Controllers
{
    [Route("product/")]
    public class ProductsController : Controller
    {
        private IProductBiz dao;

        public ProductsController(IProductBiz dao)
        {
            this.dao = dao;
        }

        [HttpGet()]
        public async Task<IActionResult> QueryAllProduct()
        {
            var products = this.dao.QueryAllProducts();
            return View("Index", products);
        }

        [HttpGet("name/{name}")]
        public async Task<IActionResult> QueryProductByName(string name)
        {
            var products = this.dao.QueryProductByProductName(name);
            return View("Index", products);
        }

        [HttpGet("style/{style}")]
        public async Task<IActionResult> QueryProductByProductStyle(string style)
        {
            var products = this.dao.QueryProductByProductStyle(style);
            return View("Index", products);
        }

        [HttpGet("situation/{situation}")]
        public async Task<IActionResult> QueryProductsBySituation(string situation)
        {
            var products = this.dao.QueryProductsBySituation(situation);
            return View("Index", products);
        }
    }
}
