using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Dao;
using AdpStore.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace AdpStore.Biz
{
    public class ProductBiz : IProductBiz
    {
        private IProductDao dao;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ProductBiz(IProductDao dao, IHostingEnvironment hostingEnvironment)
        {
            this.dao = dao;
            _hostingEnvironment = hostingEnvironment;
        }

        public int AddNewProduct(Product newProduct)
        {
            return this.dao.AddNewProduct(newProduct);
        }

        public void DeleteProductById(int productId)
        {
            this.dao.DeleteProductById(productId);
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

        public void UpdateProduct(Product product)
        {
            this.dao.UpdateProduct(product);
        }

        public Product QueryProductById(int productId)
        {
            return this.dao.QueryProductDetail(productId);
        }

        public void saveProductImg(IFormFile file, int productProductId)
        {
            if (file == null)
            {
                return;
            }

            string fileExt = this.getFileExt(file.FileName);
            var newFileName = this._hostingEnvironment.WebRootPath + "/wwwroot/images/prodduct-" + productProductId + "." + fileExt;

            using (var stream = new FileStream(newFileName, FileMode.Create))
            {
                file.CopyTo(stream);
            }
        }

        private string getFileExt(string fileName)
        {
            return fileName.Split(new[] {'.'}, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}
