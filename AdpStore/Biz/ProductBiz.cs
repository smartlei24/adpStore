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

        public void AddNewProduct(Product newProduct, IFormFile image)
        {
            if (image != null)
            {
                newProduct.ImageName = this.saveProductImg(image);
            }
            else
            {
                newProduct.ImageName = "product-default.jpg";
            }

            this.dao.AddNewProduct(newProduct);
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

        public void UpdateProduct(Product product, IFormFile image)
        {
            if (image != null)
            {
                product.ImageName = this.saveProductImg(image);
            }

            this.dao.UpdateProduct(product);
        }

        public Product QueryProductById(int productId)
        {
            return this.dao.QueryProductDetail(productId);
        }

        private string saveProductImg(IFormFile file)
        {
            string fileExt = this.getFileExt(file.FileName);
            string fileName = System.Guid.NewGuid().ToString() + "." + fileExt;
            var newFileName = this._hostingEnvironment.WebRootPath + "/images/" + fileName;

            using (var stream = new FileStream(newFileName, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return fileName;
        }

        private string getFileExt(string fileName)
        {
            return fileName.Split(new[] {'.'}, StringSplitOptions.RemoveEmptyEntries).Last();
        }
    }
}
