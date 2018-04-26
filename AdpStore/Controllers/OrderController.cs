using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AdpStore.Biz;
using AdpStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdpStore.Controllers
{
    [Route("order/")]
    public class OrderController : Controller
    {
        private IOrderBiz biz;

        public OrderController(IOrderBiz biz)
        {
            this.biz = biz;
        }

        [HttpGet("user/{userName}")]
        public IActionResult GetOrderListByUser(string userName)
        {
            var orders = this.biz.GetOrderListByUserName(userName);
            return View("Index", orders);
        }

        [HttpGet("{orderId}")]
        public IActionResult GetOrderDetailById(int orderId)
        {
            return View("Index");
        }

        [HttpPost()]
        public int AddNewOrder(string userName)
        {
            var productId = this.biz.AddNewOrder(userName);
            return productId;
        }
    }
}