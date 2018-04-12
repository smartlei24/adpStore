using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AdpStore.Models;
using VIC.DataAccess.MSSql;
using System.IO;
using VIC.DataAccess.Config;
using AdpStore.Dao;
using VIC.DataAccess.Abstraction;
using VIC.ObjectConfig.Abstraction;
using VIC.ObjectConfig.Merge;

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
                .UseDataAccessConfig(dbDirectory, false, null, "db.Development.xml", "Product.xml")
                .BuildServiceProvider();

            services
                .AddSingleton<IProductDao, ProductDao>();

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
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}");
            });
        }
    }
}
