using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Biz
{
    public interface IOrderBiz
    {
        Order AddNewOrder(Order newOrder);

        Order GetOrderDetailById(int orderId);

        List<Order> GetOrderListByUserId(int userId);
    }
}
