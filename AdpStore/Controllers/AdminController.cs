using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdpStore.Biz;
using AdpStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdpStore.Controllers
{
    [Route("admin/")]
    public class AdminController : Controller
    {
        private IUserBiz userBiz;
        private IProductBiz productBiz;

        public AdminController(IUserBiz userBiz, IProductBiz productBiz)
        {
            this.userBiz = userBiz;
            this.productBiz = productBiz;
        }

        public IActionResult Index()
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                return Redirect("/login/login");
            }
            if (User.Identity.Name != "Admin")
            {
                return StatusCode(404);
            }
            return View();
        }

        [HttpGet("user/")]
        public IActionResult GetAllUser(int? page)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                return Redirect("/login/login");
            }
            if (User.Identity.Name != "Admin")
            {
                return StatusCode(404);
            }
            var users = this.userBiz.QueryAllUser();
            return View("UserList", PaginatedList<User>.Create(users.AsQueryable(), page ?? 1, 20));
        }

        [HttpDelete("user/")]
        public void DeleteUserById(int userId)
        {
            if (User.Identity.Name != "Admin")
            {
                return;
            }
            this.userBiz.DeleteUserById(userId);
        }

        [HttpGet("user-editor/{userId}")]
        public IActionResult GetUpdatePage(int userId)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                return Redirect("/login/login");
            }
            if (User.Identity.Name != "Admin")
            {
                return StatusCode(404);
            }
            var user = this.userBiz.GetUserById(userId);
            return View("editUser", user);
        }

        [HttpPost("user-editor/")]
        public IActionResult UpdateUserById(User user)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                return Redirect("/login/login");
            }
            if (User.Identity.Name != "Admin")
            {
                return StatusCode(404);
            }
            this.userBiz.UpdateUser(user);
            return Redirect("/admin/user");
        }

        [HttpGet("product/new")]
        public IActionResult NewProduct()
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                return Redirect("/login/login");
            }
            if (User.Identity.Name != "Admin")
            {
                return StatusCode(404);
            }
            return View("AddNewProduct");
        }

        [HttpPost("product/new-product")]
        public IActionResult AddNewProduct(Product product, IFormFile file)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                return Redirect("/login/login");
            }
            if (User.Identity.Name != "Admin")
            {
                return StatusCode(404);
            }
            this.productBiz.AddNewProduct(product, file);
            return Redirect("/admin/product/");
        }

        [HttpPost("product/edit-product")]
        public IActionResult UpdateProductInfo(Product product, IFormFile file)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                return Redirect("/login/login");
            }
            if (User.Identity.Name != "Admin")
            {
                return StatusCode(404);
            }
            this.productBiz.UpdateProduct(product, file);
            return Redirect("/admin/product/");
        }

        [HttpDelete("product/")]
        public void DeleteProductById(int productId)
        {
            if (User.Identity.Name != "Admin")
            {
                return;
            }
            this.productBiz.DeleteProductById(productId);
        }

        [Route("product/")]
        public IActionResult AdminAllProduct(int? page)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                return Redirect("/login/login");
            }
            if (User.Identity.Name != "Admin")
            {
                return StatusCode(404);
            }
            var products = this.productBiz.QueryAllProducts();
            return View("AdminProduct", PaginatedList<Product>.Create(products.AsQueryable(), page ?? 1, 8));
        }

        [HttpGet("product-edit/{productId}")]
        public IActionResult EditProductPage(int productId)
        {
            if (string.IsNullOrWhiteSpace(User.Identity.Name))
            {
                return Redirect("/login/login");
            }
            if (User.Identity.Name != "Admin")
            {
                return StatusCode(404);
            }
            var product = this.productBiz.QueryProductById(productId);
            return View("EditProduct", product);
        }
    }
}