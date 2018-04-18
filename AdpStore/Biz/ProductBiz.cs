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

        public List<Product> QueryAllProducts()
        {
            return this.dao.QueryAllProducts();
        }

        public List<Product> QueryProductByProductName(string productName)
        {
            var products = this.dao.QueryProductByProductName(productName);
            return products;
        }

        public List<Product> QueryProductByProductStyle(string style)
        {
            var products = this.dao.QueryProductByProductStyle(style);
            return products;
        }

        public Product QueryProductDetail(int productId)
        {
            return this.dao.QueryProductDetail(productId);
        }

        public List<Product> QueryProductsBySituation(string situation)
        {
            return this.dao.QueryProductBySituation(situation);
        }

        public Product UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
