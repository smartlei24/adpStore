using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Models;
using VIC.DataAccess.Abstraction;

namespace AdpStore.Dao
{
    public class ShoppingCartDao : IShoppingCartDao
    {
        private IDbManager _db;

        public ShoppingCartDao(IDbManager db)
        {
            _db = db;
        }

        public void AddShoppingCart(ShoppingCart shoppingCart)
        {
            this._db.GetCommand("AddANewShopingCart").ExecuteNonQuery(shoppingCart);
        }

        public void DeleteAllShoppingCartByUserName(User userId)
        {
            this._db.GetCommand("DeleteAllShoppingCartByUserName").ExecuteNonQuery(new
            {
                UserId = userId
            });
        }

        public void DeleteShoppingCartById(int id)
        {
            this._db.GetCommand("QueryShoppingCartByUserName").ExecuteNonQuery(new
            {
                ShoppingId = id
            });
        }

        public List<ShoppingCart> QueryShoppingCartByUserName (int id)
        {
            throw new NotImplementedException();
        }
    }
}
