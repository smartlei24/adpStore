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

        public int AddNewProduct(Product newProduct)
        {
            return this._db.GetCommand("InsertANewProduct").ExecuteScalar<int>(newProduct);
        }

        public void DeleteProductById(int productId)
        {
            this._db.GetCommand("DeleteAExistProduct").ExecuteNonQuery(new
            {
                ProductId = productId
            });
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

        public void UpdateProduct(Product product)
        {
            this._db.GetCommand("UpdateProductInfo").ExecuteNonQuery(product);
        }
    }
}
