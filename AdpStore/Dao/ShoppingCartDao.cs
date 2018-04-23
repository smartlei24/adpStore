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

        public void DeleteAllShoppingCartByUserName(string userName)
        {
            this._db.GetCommand("DeleteAllShoppingCartByUserName").ExecuteNonQuery(new
            {
                UserName = userName
            });
        }

        public void DeleteShoppingCartById(int productId, string userName)
        {
            this._db.GetCommand("DeleteShoppingCartByProductId").ExecuteNonQuery(new
            {
                ProductId = productId,
                UserName = userName
            });
        }

        public List<ShoppingCart> QueryShoppingCartByUserName(string name)
        {
            return this._db.GetCommand("QueryShoppingCartByUserName")
                .ExecuteEntityList<ShoppingCart>(new
                {
                    UserName = name
                });
        }
    }
}
