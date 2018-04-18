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
            return this._db.GetCommand("QueryAllProducts")
                .ExecuteEntityList<Product>();
        }

        public List<Product> QueryProductByProductName(string productName)
        {
            var a = this._db.GetCommand("QueryProductByProductName");
            var b = a.ExecuteEntityList<Product>(new
                {
                    ProductName = productName
                });
            return b;
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
            return this._db.GetCommand("QueryProductById").ExecuteEntity<Product>(new
            {
                ProductId = productId
            });
        }

        public Product UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
