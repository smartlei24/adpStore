﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Biz;
using Microsoft.AspNetCore.Mvc;

namespace AdpStore.Controllers
{
    public class ProductDetailController : Controller
    {
        private IProductBiz biz;

        public ProductDetailController(IProductBiz _biz)
        {
            this.biz = _biz;
        }

        [HttpGet("product-detail/{id}")]
        public IActionResult GetProductDetailById(int id)
        {
            var product = this.biz.QueryProductDetail(id);
            return View("Index", product);
        }
    }
}