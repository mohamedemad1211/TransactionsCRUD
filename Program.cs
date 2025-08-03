using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //DI for DbContext
            builder.Services.AddDbContext<TranDbContext>(options=>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Transactions}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
