using Microsoft.EntityFrameworkCore;
using ProniaTask.DAL;

namespace ProniaTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDBContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Mssql"));
            });
            var app = builder.Build();
            
            
            app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Manage}/{action=Index}"
          );

            app.MapControllerRoute(
                name: "default",
                pattern:"{controller=Home}/{action=Index}/{id?}"
                );
            app.UseStaticFiles();
            app.Run();
        }
    }
}
