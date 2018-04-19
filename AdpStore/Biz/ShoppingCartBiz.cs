using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Dao;
using AdpStore.Models;

namespace AdpStore.Biz
{
    public class ShoppingCartBiz : IShoppingCartBiz
    {
        private IShoppingCartDao dao;

        public ShoppingCartBiz(IShoppingCartDao dao)
        {
            this.dao = dao;
        }

        public void AddShoppingCart(ShoppingCart shoppingCart)
        {
            this.dao.AddShoppingCart(shoppingCart);
        }

        public void DeleteShoppingCartById(int id)
        {
            this.DeleteShoppingCartById(id);
        }

        public void EmptyUserShoppingCart(string userId)
        {
            this.EmptyUserShoppingCart(userId);
        }

        public List<ShoppingCart> QueryShoppingCartByUserName(string id)
        {
            return this.QueryShoppingCartByUserName(id);
        }
    }
}
