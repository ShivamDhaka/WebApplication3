//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Context;
using WebApplication3.Repository;

namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<UseDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("UseDbConnection"));

            });
            builder.Services.AddTransient<ISupplier, SupplierRepository>();
            builder.Services.AddTransient<IInventory, InventoryRepository>();

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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
