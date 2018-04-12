using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Models;
using VIC.DataAccess.Abstraction;

namespace AdpStore.Dao
{
    public class ProductDao : IProductDao
    {
        private IDbManager _db;

        public ProductDao(IDbManager db)
        {
            _db = db;
        }

        public bool AddNewProduct(Product newProduct)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> QueryAllProducts()
        {
            throw new NotImplementedException();
        }

        public List<Product> QueryProductByProductName(string productName)
        {
            return this._db.GetCommand("QueryProductByProductName")
                .ExecuteEntityList<Product>(productName);
        }

        public List<Product> QueryProductByProductStyle(string style)
        {
            return this._db.GetCommand("QueryProductByProductStyle").ExecuteEntityList<Product>(new
            {
                Style = style
            });
        }

        public List<Product> QueryProductBySituation(string situation)
        {
            return this._db.GetCommand("QueryProductBySituation").ExecuteEntityList<Product>(new
            {
                Situation = situation
            });
        }

        public Product QueryProductDetail(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> QueryProductsBySituation(string situation)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
