using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Dao
{
    public interface IShoppingCartDao
    {
        List<ShoppingCart> QueryShoppingCartByUserId(int id);

        void AddShoppingCart(ShoppingCart shoppingCart);

        void DeleteShoppingCartById(int id);

        void DeleteAllShoppingCartByUserId(User userId);
    }
}
