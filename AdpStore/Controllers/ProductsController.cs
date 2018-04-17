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
        public async Task<IActionResult> QueryAllProduct()
        {
            var products = this.biz.QueryAllProducts();
            return View("Index", products);
        }

        [HttpGet("name/{name}")]
        public async Task<IActionResult> QueryProductByName(string name, int pageNumber)
        {
            var result = this.biz.QueryProductByProductName(name, pageNumber);
            result.RedirectUrl = "~/name/";

            return View("Index", result);
        }

        [HttpGet("style/{style}")]
        public async Task<IActionResult> QueryProductByProductStyle(string style)
        {
            var products = this.biz.QueryProductByProductStyle(style);
            return View("Index", products);
        }

        [HttpGet("situation/{situation}")]
        public async Task<IActionResult> QueryProductsBySituation(string situation)
        {
            var products = this.biz.QueryProductsBySituation(situation);
            return View("Index", products);
        }

        [HttpPut("product")]
        public async Task<IActionResult> UpdateProductInfo(Product product)
        {
            var updatedProduct = this.biz.UpdateProduct(product);
            return View("Index", updatedProduct);
        }

        [HttpDelete("product/{id}")]
        public async Task<IActionResult> DeleteProductById(int id)
        {
            var isSuccessful = this.biz.DeleteProductById(id);
            return View("Index");
        }

        [HttpPost("product/")]
        public async Task<IActionResult> AddNewProduct(Product product)
        {
            var updatedProduct = this.biz.AddNewProduct(product);
            return View("Index", updatedProduct);
        }
    }
}
