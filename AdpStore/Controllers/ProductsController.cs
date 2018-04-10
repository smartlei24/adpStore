﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdpStore.Models;
using AdpStore.Dao;

namespace AdpStore.Controllers
{
    public class ProductsController : Controller
    {
        private IAdpDao dao;

        public ProductsController(IAdpDao dao)
        {
            this.dao = dao;
        }

        [HttpGet("products/style/{style}")]
        public async Task<IActionResult> QueryProductByStyle(string style)
        {
            var products = this.dao.QueryProductByProductStyle(style);
            return View(products);
        }
    }
}
