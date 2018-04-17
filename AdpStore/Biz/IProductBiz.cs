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

        QueryProductResult QueryAllProducts();

        QueryProductResult QueryProductByProductName(string productName, int pageNumber);

        QueryProductResult QueryProductByProductStyle(string style);

        QueryProductResult QueryProductsBySituation(string situation);

        bool AddNewProduct(Product newProduct);

        bool DeleteProductById(int productId);

        Product UpdateProduct(Product product);
    }
}
