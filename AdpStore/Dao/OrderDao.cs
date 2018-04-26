using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Models;
using VIC.DataAccess.Abstraction;

namespace AdpStore.Dao
{
    public class OrderDao : IOrderDao
    {
        private IDbManager _db;

        public OrderDao(IDbManager db)
        {
            _db = db;
        }

        public void AddNewOrder(Order newOrder)
        {
            this._db.GetCommand("InsertANewOrder").ExecuteNonQuery<Order>(newOrder);
        }

        public int GetMaxOrderIdFormDb()
        {
            return this._db.GetCommand("GetMaxOrderId").ExecuteScalar<int>();
        }

        public Order QueryOrderByOrderId(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> QueryOrderByUserName(string userName)
        {
            return this._db.GetCommand("QueryOrderByUserName").ExecuteEntityList<Order>(new
            {
                UserName = userName
            });
        }

        public decimal GetBalanceByUserName(string userName)
        {
            return this._db.GetCommand("GetBalanceByUserName").ExecuteScalar<decimal>(new
            {
                UserName = userName
            });
        }

        public void SubtractUserBalance(string userName, decimal orderAmt)
        {
            this._db.GetCommand("SubtractUserBalance").ExecuteNonQuery(new
            {
                UserName = userName,
                OrderAmt = orderAmt
            });
        }
    }
}
