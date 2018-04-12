using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Biz;
using Microsoft.AspNetCore.Mvc;

namespace AdpStore.Controllers
{
    [Route("product-detail")]
    public class ProductDetailController : Controller
    {
        private IProductBiz biz;

        public ProductDetailController(IProductBiz _biz)
        {
            this.biz = _biz;
        }

        [HttpGet("product/{id}")]
        public async Task<IActionResult> GetProductDetailById(int id)
        {
            var product = this.biz.QueryProductDetail(id);
            return View("Index", product);
        }
    }
}