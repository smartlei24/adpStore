using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Biz;
using AdpStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdpStore.Controllers
{
    [Route("shopping-cart")]
    public class ShoppingCartController : Controller
    {
        private IShoppingCartBiz biz;

        public ShoppingCartController(IShoppingCartBiz biz)
        {
            this.biz = biz;
        }

        [HttpGet("/{userId}")]
        public async Task<IActionResult> GetUsersShoppingCart(int userId)
        {
            var records = this.biz.QueryShoppingCartByUserId(userId);
            return View("Index", records);
        }

        [HttpPost()]
        public async Task<IActionResult> AddShoppingCart(ShoppingCart shoppingCart)
        {
            this.biz.AddShoppingCart(shoppingCart);
            var records = this.biz.QueryShoppingCartByUserId(shoppingCart.UserId);
            return View("Index", records);
        }

        [HttpDelete()]
        public async Task<IActionResult> DeleteShoppingCart(ShoppingCart shoppingCart)
        {
            this.biz.AddShoppingCart(shoppingCart);
            var records = this.biz.QueryShoppingCartByUserId(shoppingCart.UserId);
            return View("Index", records);
        }

        [HttpDelete("/{userId}")]
        public async Task<IActionResult> EmptyShoppingCart(int userId)
        {
            this.biz.EmptyUserShoppingCart(userId);
            var records = this.biz.QueryShoppingCartByUserId(userId);
            return View("Index", records);
        }
    }
}