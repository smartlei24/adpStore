using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Models;

namespace AdpStore.Dao
{
    public class OrderDao : IOrderDao
    {
        public Order AddNewOrder(Order newOrder)
        {
            throw new NotImplementedException();
        }

        public Order QueryOrderByOrderId(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> QueryOrderByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
