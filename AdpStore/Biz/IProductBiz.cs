using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Biz
{
    public interface IProductBiz
    {
        Product QueryProductDetail(int productId);

        List<Product> QueryAllProducts();

        List<Product> QueryProductByProductName(string productName);

        List<Product> QueryProductByProductStyle(string style);

        List<Product> QueryProductsBySituation(string situation);

        bool AddNewProduct(Product newProduct);

        bool DeleteProductById(int productId);

        Product UpdateProduct(Product product);
    }
}
