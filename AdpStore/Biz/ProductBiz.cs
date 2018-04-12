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
            throw new NotImplementedException();
        }

        public List<Product> QueryProductByProductName(string productName)
        {
            throw new NotImplementedException();
        }

        public List<Product> QueryProductByProductStyle(string style)
        {
            throw new NotImplementedException();
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
