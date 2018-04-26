using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Dao
{
    public interface IOrderDao
    {
        List<Order> QueryOrderByUserName(string userName);

        Order QueryOrderByOrderId(int orderId);

        void AddNewOrder(Order newOrder);

        int GetMaxOrderIdFormDb();

        decimal GetBalanceByUserName(string userName);

        void SubtractUserBalance(string userName, decimal orderAmt);
    }
}
