using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NestTask.DAL;
using NestTask.Models;

namespace NestTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-.";
                opt.User.RequireUniqueEmail = true;
                opt.Password.RequiredLength = 8;
                opt.Lockout.AllowedForNewUsers = true;
                opt.Lockout.MaxFailedAccessAttempts = 3;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(2);

            }).AddEntityFrameworkStores<AppDBContext>();
            builder.Services.AddDbContext<AppDBContext>(opt => {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Mssql"));
            });
            var app = builder.Build();
           
      

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
