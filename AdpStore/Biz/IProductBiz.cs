using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AdpStore.Biz
{
    public interface IProductBiz
    {
        Product QueryProductDetail(int productId);

        List<Product> QueryAllProducts();

        List<Product> QueryProductByProductName(string productName);

        List<Product> QueryProductByProductStyle(string style);

        List<Product> QueryProductsBySituation(string situation);

        void AddNewProduct(Product newProduct, IFormFile image);

        void DeleteProductById(int productId);

        void UpdateProduct(Product product, IFormFile image);

        Product QueryProductById(int productId);
    }
}
