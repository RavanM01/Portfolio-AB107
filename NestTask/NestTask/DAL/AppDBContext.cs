using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NestTask.Models;

namespace NestTask.DAL
{
    public class AppDBContext :IdentityDbContext<AppUser>
    {
        public AppDBContext(DbContextOptions opt):base(opt)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
    }
}
