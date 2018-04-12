using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Biz;
using AdpStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdpStore.Controllers
{
    [Route("order")]
    public class OrderController : Controller
    {
        private IOrderBiz biz;

        public OrderController(IOrderBiz biz)
        {
            this.biz = biz;
        }

        [HttpGet()]
        public IActionResult GetOrderListByUser()
        {
            return View("Index");
        }

        [HttpGet("/{orderId}")]
        public IActionResult GetOrderDetailById(int orderId)
        {
            return View("Index");
        }

        [HttpPost("")]
        public IActionResult AddNewOrder(Order order)
        {
            return View("Index");
        }
    }
}