using Microsoft.EntityFrameworkCore;
using TrainingStudio.Contexts;
using TrainingStudio.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string? connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString ));

builder.Services.AddScoped<ProgramService>();

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
