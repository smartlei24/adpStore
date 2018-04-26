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
        private IProductBiz biz;

        public ProductsController(IProductBiz biz)
        {
            this.biz = biz;
        }

        [HttpGet()]
        public IActionResult QueryAllProduct(int? page)
        {
            var products = this.biz.QueryAllProducts();
            return View("Index", PaginatedList<Product>.Create(products.AsQueryable(), page ?? 1, 6));
        }

        [HttpGet("name/{name}")]
        public IActionResult QueryProductByName(string name, string currentFilter, string searchString, int? page)
        {
            var products = this.biz.QueryProductByProductName(name);
            return View("Index", PaginatedList<Product>.Create(products.AsQueryable(), page ?? 1, 6));
        }

        [HttpGet("style/{style}")]
        public IActionResult QueryProductByProductStyle(string style, int? page)
        {
            var products = this.biz.QueryProductByProductStyle(style);
            return View("Index", PaginatedList<Product>.Create(products.AsQueryable(), page ?? 1, 6));
        }

        [HttpGet("situation/{situation}")]
        public IActionResult QueryProductsBySituation(string situation, int? page)
        {
            var products = this.biz.QueryProductsBySituation(situation);
            return View("Index", PaginatedList<Product>.Create(products.AsQueryable(), page ?? 1, 6));
        }
    }
}
