using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project_n9ws.Data;
using Project_n9ws.Models;
using Project_n9ws.Services;
using Project_n9ws.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_n9ws
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<NewsContextDb>(option => option.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("MyFirstProject")));
            services.AddControllersWithViews();
            services.AddScoped<INew<Category>, CategoryManger>();
            services.AddScoped<INew<ContactUs>, ContactManager>();
            services.AddTransient<INewsByID<New>, NewManager>();
            services.AddTransient<INew<User>, UserManager>();
            services.AddTransient<INew<Country>, CountryManager>();
            services.AddScoped<SearchEmail>();
            services.AddTransient<INewsByID<New>, NewManager>();
            services.AddTransient<INew<Comment>, CommentManager>();
            services.AddTransient<INew<Team>, TeamManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("New/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{Controller=News}/{action=Index}/{Id?}"
                    );
            });
        }
    }
}




