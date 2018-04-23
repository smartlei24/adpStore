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

        private IShoppingCartDao shoppingDao;

        public OrderBiz(IOrderDao dao, IShoppingCartDao shoppingDao)
        {
            this.dao = dao;
            this.shoppingDao = shoppingDao;
        }

        public int AddNewOrder(string userName)
        {
            var shoppingRecords = this.shoppingDao.QueryShoppingCartByUserName(userName);
            var orderId = this.dao.GetMaxOrderIdFormDb() + 1;
            var order = shoppingRecords.GroupBy(i => i.ProductId).ToList();
            order.ForEach(i =>
            {
                this.dao.AddNewOrder(new Order
                {
                    OrderId = orderId,
                    UserName = userName,
                    ProductId = i.FirstOrDefault().ProductId,
                    OrderPrice = i.Select(r => r.Price).Sum(),
                    Quantity = i.Count()
                });
            });
            this.shoppingDao.DeleteAllShoppingCartByUserName(userName);
            return orderId;
        }

        public Order GetOrderDetailById(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrderListByUserName(string userName)
        {
            return this.dao.QueryOrderByUserName(userName);
        }
    }
}
