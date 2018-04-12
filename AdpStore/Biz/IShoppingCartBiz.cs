using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Biz
{
    public interface IShoppingCartBiz
    {
        List<ShoppingCart> QueryShoppingCartByUserId(int id);

        void AddShoppingCart(ShoppingCart shoppingCart);

        void DeleteShoppingCartById(int id);

        void EmptyUserShoppingCart(int userId);
    }
}
