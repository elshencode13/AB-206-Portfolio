namespace Program;

public static class MainClass
{
    public static void Main()
    {

        var builder = WebApplication.CreateBuilder();
        builder.Services.AddControllersWithViews();

        var app = builder.Build();
        app.UseFileServer();

        app.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                  );
        app.MapControllerRoute(

            name: "default",
            pattern: "{controller=Home}/{action=Index}"

                  );



        app.Run();



    }
}