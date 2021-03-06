﻿using System;
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

        public void DeleteShoppingCartById(int id, string userName)
        {
            this.dao.DeleteShoppingCartById(id, userName);
        }

        public void EmptyUserShoppingCart(string userId)
        {
            this.dao.DeleteAllShoppingCartByUserName(userId);
        }

        public List<ShoppingCart> QueryShoppingCartByUserName(string name)
        {
            return this.dao.QueryShoppingCartByUserName(name);
        }
    }
}
