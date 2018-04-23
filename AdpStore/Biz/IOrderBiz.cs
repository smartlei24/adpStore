using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Biz
{
    public interface IOrderBiz
    {
        int AddNewOrder(string userName);

        Order GetOrderDetailById(int orderId);  

        List<Order> GetOrderListByUserName(string userName);
    }
}
