using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Biz;
using AdpStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdpStore.Controllers
{
    [Route("shopping-cart/")]
    public class ShoppingCartController : Controller
    {
        private IShoppingCartBiz biz;

        public ShoppingCartController(IShoppingCartBiz biz)
        {
            this.biz = biz;
        }

        [HttpGet("user/{userName}")]
        public IActionResult GetUsersShoppingCart(string userName)
        {
            var records = this.biz.QueryShoppingCartByUserName(userName);
            return View("Index", records);
        }

        [HttpPost()]
        public void AddShoppingCart(string userName, int productId)
        {
            var shoppingCart = new ShoppingCart { UserName = userName, ProductId = productId };
            this.biz.AddShoppingCart(shoppingCart);
            return;
        }

        [HttpDelete("product/{productId}")]
        public void DeleteShoppingCart(int productId, string userName)
        {
            this.biz.DeleteShoppingCartById(productId, userName);
            return;
        }

        [HttpDelete("user/{userId}")]
        public void EmptyShoppingCart(string userName)
        {
            this.biz.EmptyUserShoppingCart(userName);
            return;
        }
    }
}
