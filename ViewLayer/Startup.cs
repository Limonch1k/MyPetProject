using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Model;
using BusinesLogicLayer.Functionality;
using DataAccessLayer.Repositories;
using DataAccessLayer.DataModel;
using KotelSite.Mapper.BusinesDataToDataModel;
using KotelSite.Mapper.BusinesDataToViewModel;
using KotelSite.Mapper.DataModelToModel;

namespace KotelSite
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
            services.AddAutoMapper(typeof(CartBLtoDataCart), typeof(CouponBLtoDataCoupon), typeof(OrderStoryBLtoDataOrderStory), typeof(ProductBLtoDataProduct),typeof(ProductClassBLtoDataProductClass), typeof(UserBLtoDataUser), typeof(UserRequestBLtoDataUserRequest));
            services.AddAutoMapper(typeof(CartBLtoCartPL), typeof(CouponBLtoCouponPL),typeof(OrderStoryBLtoOrderStoryPL), typeof(ProductBLtoProductPL), typeof(ProductClassBLtoProductClassPL), typeof(UserBLtoUserPL), typeof(UserRequestBLtoUserRequestPL));
            services.AddAutoMapper(typeof(DataCartToCart), typeof(DataCouponToCoupon), typeof(DataOrderStoryToOrderStory), typeof(DataProductToProduct), typeof(DataProductClassToProductClass), typeof(DataUserToUser), typeof(DataUserRequestToUserRequest));
            services.AddControllersWithViews();
            services.AddScoped<CartRepo>();
            services.AddScoped<CouponRepo>();
            services.AddScoped<OrderStoryRepo>();
            services.AddScoped<ProductRepo>();
            services.AddScoped<ProductClassRepo>();
            services.AddScoped<UserRepo>();
            services.AddScoped<UserRequestRepo>();
            services.AddScoped<CartServices>();
            services.AddScoped<CouponServices>();
            services.AddScoped<OrderStoryServices>();
            services.AddScoped<ProductServices>();
            services.AddScoped<ProductClassServices>();
            services.AddScoped<UserServices>();
            services.AddScoped<UserRequestServices>();
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<KotelContext>(options =>
                options.UseSqlServer(connection));
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
            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Main}/{action=MainPage}/{id?}");
            });
        }
    }
}
