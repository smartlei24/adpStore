using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Dao
{
    public interface IShoppingCartDao
    {
        List<ShoppingCart> QueryShoppingCartByUserName(string name);

        void AddShoppingCart(ShoppingCart shoppingCart);

        void DeleteShoppingCartById(int productId, string userName);

        void DeleteAllShoppingCartByUserName(string userId);
    }
}
