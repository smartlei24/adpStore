using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Biz
{
    public interface IShoppingCartBiz
    {
        List<ShoppingCart> QueryShoppingCartByUserName(string userName);

        void AddShoppingCart(ShoppingCart shoppingCart);

        void DeleteShoppingCartById(int productId, string userName);

        void EmptyUserShoppingCart(string userName);
    }
}
