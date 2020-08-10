using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaStore.Storing;

namespace PizzaStore.Client
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllersWithViews();
      services.AddDbContext<PizzaStoreDbContext>(options =>
      {
        options.UseSqlServer(Configuration.GetConnectionString("MvcPizzaStoreContext"));
        // options.UseSqlServer("server=revaturetraining-p1.database.windows.net;database=pizzastoredb;User id=sqladmin; password=<yourpassword>");
        // options.UseSqlServer(Configuration["DataConnect:mssql"]);
        // options.UseSqlServer(Configuration["DataConnect:mssql:dev"]);
      });
      // services.AddCors(options =>
      // {
      //   options.AddDefaultPolicy(poli =>
      //   {
      //     poli.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
      //   });
      //   options.AddPolicy("private", poli => {
      //     poli.WithOrigins("microsoft.com").WithMethods("get", "post").WithHeaders("content-type");
      //   });
      // });
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
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }
      // app.UseCors(); // <-- this will implement the default policy, global
      app.UseHttpsRedirection(); // you come in as http but I redirect you to https
      app.UseStaticFiles();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints => // <-- this is global routing. use global only or method only
      {
        endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");
      });
    }
  }
}