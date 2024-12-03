using Microsoft.EntityFrameworkCore;
using Riode.Models;

namespace Riode.DAL
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions opt):base(opt)
        {
            
        }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Slider> sliders { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
    }
}
