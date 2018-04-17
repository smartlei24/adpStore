using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Dao;
using AdpStore.Models;

namespace AdpStore.Biz
{
    public class ProductBiz : IProductBiz
    {
        private IProductDao dao;

        private int pageSize = 6;

        public ProductBiz(IProductDao dao)
        {
            this.dao = dao;
        }

        public bool AddNewProduct(Product newProduct)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public QueryProductResult QueryAllProducts()
        {
            throw new NotImplementedException();
        }

        public QueryProductResult QueryProductByProductName(string productName, int pageNumber)
        {
            var pageStart = (pageNumber - 1) * this.pageSize;

            var dataCount = this.dao.QueryCountOfProductByProductName(productName);
            int pageCount = (int)Math.Ceiling(dataCount / (pageSize * 1.0));

            var products = this.dao.QueryProductByProductName(productName, pageStart, pageSize);

            var queryResult = new QueryProductResult
            {
                DataCount = dataCount,
                Data = products
            };
            return queryResult;
        }

        public QueryProductResult QueryProductByProductStyle(string style)
        {
            throw new NotImplementedException();
        }

        public Product QueryProductDetail(int productId)
        {
            throw new NotImplementedException();
        }

        public QueryProductResult QueryProductsBySituation(string situation)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
