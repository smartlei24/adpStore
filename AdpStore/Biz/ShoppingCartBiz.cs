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
            throw new NotImplementedException();
        }

        public void DeleteShoppingCartById(int id)
        {
            throw new NotImplementedException();
        }

        public void EmptyUserShoppingCart(int userId)
        {
            throw new NotImplementedException();
        }

        public List<ShoppingCart> QueryShoppingCartByUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
