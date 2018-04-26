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

        List<Product> QueryProductBySituation(string situation); 

        Product QueryProductDetail(int productId);

        int AddNewProduct(Product newProduct);

        void DeleteProductById(int productId);

        void UpdateProduct(Product product);
    }
}
