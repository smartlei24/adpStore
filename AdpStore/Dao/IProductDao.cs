using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Dao
{
    public interface IProductDao
    {
        List<Product> QueryAllProducts();

        List<Product> QueryProductByProductName(string productName);

        List<Product> QueryProductByProductStyle(string style);

        List<Product> QueryProductsBySituation(string situation);

        Product QueryProductDetail(int productId);

        bool AddNewProduct(Product newProduct);

        bool DeleteProductById(int productId);

        Product UpdateProduct(Product product);
    }
}
