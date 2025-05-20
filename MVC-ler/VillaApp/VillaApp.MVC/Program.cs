using Microsoft.EntityFrameworkCore;
using ViIla.DAL.Contexts;
using VillaApp.BL.Services;

namespace VillaApp.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            string? connectionString = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));
            builder.Services.AddScoped<ProductService>();
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllerRoute(
              name: "areas",
              pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
            );
            app.MapControllerRoute(
                
                name: "default",
                pattern: "{controller=Home}/{action=Index}"
                
                );



            app.Run();
        }
    }
}
