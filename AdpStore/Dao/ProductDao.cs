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

        public List<Product> QueryAllProducts(int pageStart, int pageSize)
        {
            return this._db.GetCommand("QueryAllProducts")
                .ExecuteEntityList<Product>(new
                {
                    PageStart = pageStart,
                    PageSize = pageSize
                });
        }

        public int QueryCountOfAllProducts()
        {
            return this._db.GetCommand("QueryAllProducts")
                .ExecuteScalar<int>();
        }


        public int QueryCountOfProductByProductStyle(string style)
        {
            throw new NotImplementedException();
        }

        public int QueryCountOfProductBySituation(string situation)
        {
            throw new NotImplementedException();
        }

        public List<Product> QueryProductByProductName(string productName, int pageStart, int pageSize)
        {
            return this._db.GetCommand("QueryProductByProductName")
                .ExecuteEntityList<Product>(new
                {
                    ProductName = productName,
                    PageStart = pageStart,
                    PageSize = pageSize
                });
        }

        public int QueryCountOfProductByProductName(string productName)
        {
            return this._db.GetCommand("QueryCountOfProductByProductName")
                .ExecuteScalar<int>(new
                {
                    ProductName = productName
                });
        }

        public List<Product> QueryProductByProductStyle(string style, int pageStart, int pageSize)
        {
            return this._db.GetCommand("QueryProductByProductStyle").ExecuteEntityList<Product>(new
            {
                Style = style,
                PageStart = pageStart,
                PageSize = pageSize
            });
        }

        public List<Product> QueryProductBySituation(string situation, int pageStart, int pageSize)
        {
            return this._db.GetCommand("QueryProductBySituation").ExecuteEntityList<Product>(new
            {
                Situation = situation,
                PageStart = pageStart,
                PageSize = pageSize
            });
        }

        public Product QueryProductDetail(int productId)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
