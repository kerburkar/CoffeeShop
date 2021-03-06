using CoffeeShop.Business.Abstract;
using CoffeeShop.Business.Concrete;
using CoffeeShop.DataAccess.Abstract;
using CoffeeShop.DataAccess.Concrete.EntityFramework;
using CoffeeShop.DataAccess.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.API
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

            services.AddControllers();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<ICoffeeService, CoffeeService>();
            services.AddTransient<ICoffeeCategoryService, CoffeeCategoryService>();
            services.AddTransient<ICoffeePlaceService, CoffeePlaceService>();
            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<IMenuCoffeeService, MenuCoffeeService>();
            services.AddTransient<IRegionService, RegionService>();

            //applicationDbContexte options parametresi tan?mland?. buradaki option sql server kullan?yor ve ba?lant?y? AppSettings.json'dan al?yor.
            //msConnection: AppSettingsteki connectionun ad?.
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MsConnection")));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CoffeeShop.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CoffeeShop.API v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
