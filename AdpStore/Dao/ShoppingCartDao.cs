using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Models;

namespace AdpStore.Dao
{
    public class ShoppingCartDao : IShoppingCartDao
    {
        public void AddShoppingCart(ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllShoppingCartByUserId(User userId)
        {
            throw new NotImplementedException();
        }

        public void DeleteShoppingCartById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ShoppingCart> QueryShoppingCartByUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
