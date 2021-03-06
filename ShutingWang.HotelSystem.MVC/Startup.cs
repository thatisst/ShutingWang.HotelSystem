using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShutingWang.HotelSystem.Core.RepositoryInterfaces;
using ShutingWang.HotelSystem.Core.ServiceInterfaces;
using ShutingWang.HotelSystem.Infrastructure.Data;
using ShutingWang.HotelSystem.Infrastructure.Helpers;
using ShutingWang.HotelSystem.Infrastructure.Repositories;
using ShutingWang.HotelSystem.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.MVC
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

            services.AddDbContext<HotelSystemDbContext>(options =>
                options.UseSqlServer(Configuration
                    .GetConnectionString("HotelSystemDbConnection")));

            services.AddAutoMapper(typeof(Startup), typeof(HotelSystemMappingProfile));

            services.AddTransient<IRoomRepository, RoomRepository>();
            services.AddTransient<IRoomTypeRepository, RoomTypeRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();

            services.AddTransient<IRoomService, RoomService>();
            services.AddTransient<IRoomTypeService, RoomTypeService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IServiceService, ServiceService>();

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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
