using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Dao;
using AdpStore.Models;

namespace AdpStore.Biz
{
    public class OrderBiz : IOrderBiz
    {
        private IOrderDao dao;

        public OrderBiz(IOrderDao dao)
        {
            this.dao = dao;
        }

        public Order AddNewOrder(Order newOrder)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderDetailById(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrderListByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
