using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Models;
using VIC.DataAccess.Abstraction;

namespace AdpStore.Dao
{
    public class AdpDao : IAdpDao
    {
        private IDbManager _db;

        public AdpDao(IDbManager db)
        {
            _db = db;
        }

        public List<Product> QueryProductByProductName(string productName)
        {
            return this._db.GetCommand("QueryProductByProductName")
                .ExecuteEntityList<Product>(productName);
        }

        public List<Product> QueryProductByProductStyle(string style)
        {
            var a = this._db.GetCommand("QueryProductByProductStyle");

            return a.ExecuteEntityList<Product>(new
            {
                Style = style
            });
        }
    }
}
