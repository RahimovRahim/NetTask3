using Microsoft.EntityFrameworkCore;

namespace ProniaAdmin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDBC>(options => {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default")); });

            var app = builder.Build();

           

            app.MapControllerRoute(
                name: "default",
                pattern: "{area:exists}/{controller=dashboard}/{action=index}/{id?}");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            app.Run();
        }
    }
}