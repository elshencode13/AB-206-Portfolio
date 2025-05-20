using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NFT.BL.Services;
using NFT.DAL.Contexts;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string? connectionString = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));
builder.Services.AddScoped<ProductService>();



var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute(
    
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );


app.Run();
