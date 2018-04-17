using AdpStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Dao
{
    public interface IProductDao
    {
        int QueryCountOfAllProducts();

        List<Product> QueryAllProducts(int pageStart, int pageSize);

        int QueryCountOfProductByProductName(string productName);

        List<Product> QueryProductByProductName(string productName, int pageStart, int pageSize);

        int QueryCountOfProductByProductStyle(string style);

        List<Product> QueryProductByProductStyle(string style, int pageStart, int pageSize);

        int QueryCountOfProductBySituation(string situation);

        List<Product> QueryProductBySituation(string situation, int pageStart, int pageSize); 

        Product QueryProductDetail(int productId);

        bool AddNewProduct(Product newProduct);

        bool DeleteProductById(int productId);

        Product UpdateProduct(Product product);
    }
}
