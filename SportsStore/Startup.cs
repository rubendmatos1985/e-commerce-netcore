using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SportsStore.Models;

namespace SportsStore
{
  public class Startup
  {
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration config) { Configuration = config; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<ApplicationDBContext>(
       opt => opt.UseSqlServer(Configuration["Data:SportStoreProducts:ConnectionString"])
      );

      services.AddDbContext<AppIdentityDbContext>(
        opt => opt.UseSqlServer(Configuration["Data:SportStoreIdentity:ConnectionString"])
      );

      services.AddIdentity<IdentityUser, IdentityRole>()
              .AddEntityFrameworkStores<AppIdentityDbContext>()
              .AddDefaultTokenProviders();

      services.AddTransient<IProductRepository, EFProductRepository>();

      services.AddTransient<IOrderRepository, EFOrderRepository>();

      services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

      services.AddScoped(sp => SessionCart.GetCart(sp));

      services.AddMvc();

      services.AddMemoryCache();

      services.AddSession();
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Error");
      }

      app.UseDeveloperExceptionPage()
         .UseStatusCodePages()
         .UseStaticFiles()
         .UseSession()
         .UseAuthentication()
         .UseMvc(routes =>
         {
           routes
             .MapRoute(
               name: null,
               template: "{category}/Page{productPage:int}",
               defaults: new { controller = "Product", action = "List", productPage = 1 }
               )
             .MapRoute(
               name: null,
               template: "Page{productPage:int}",
               defaults: new { controller = "Product", action = "List", productPage = 1 }
               )
             .MapRoute(
               name: null,
               template: "{category}",
               defaults: new { controller = "Product", action = "List", productPage = 1 }
               )
             .MapRoute(
               name: null,
               template: "",
               defaults: new { controller = "Product", action = "List", productPage = 1 }
               )
             .MapRoute(
               name: null, template: "{controller}/{action}/{id?}",
               defaults: new { controller = "Product", action = "List", productPage = 1 }
               );
         });
      IdentitySeedData.EnsurePopulated(app);
      SeedData.EnsurePopulated(app);
    }
  }
}
