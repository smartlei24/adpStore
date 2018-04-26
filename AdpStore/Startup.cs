using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VIC.DataAccess.MSSql;
using System.IO;
using VIC.DataAccess.Config;
using AdpStore.Dao;
using AdpStore.Biz;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

namespace AdpStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private static string currentDirectory = Directory.GetCurrentDirectory();
        private static string dbDirectory = Path.Combine(currentDirectory, "DB");




        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.UseDataAccess()
                .UseDataAccessConfig(dbDirectory, false, null, $"db.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.xml", "Product.xml", "User.xml", "ShoppingCart.xml", "Order.xml")
                .BuildServiceProvider();

            services
                .AddSingleton<IProductDao, ProductDao>()
                .AddSingleton<IUserBiz, UserBiz>()
                .AddSingleton<IUserDao, UserDao>()
                .AddSingleton<IProductBiz, ProductBiz>()
                .AddSingleton<IShoppingCartBiz, ShoppingCartBiz>()
                .AddSingleton<IShoppingCartDao, ShoppingCartDao>()
                .AddSingleton<IOrderDao, OrderDao>()
                .AddSingleton<IOrderBiz, OrderBiz>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option =>
                {
                    option.LoginPath = new PathString("/login");
                    option.AccessDeniedPath = new PathString("/denied");
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/error");
                app.UseStatusCodePagesWithReExecute("/error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}");
            });
        }
    }
}
