using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Dao
{
    public interface IOrderDao
    {
        List<Order> QueryOrderByUserId(int userId);

        Order QueryOrderByOrderId(int orderId);

        Order AddNewOrder(Order newOrder);
    }
}
