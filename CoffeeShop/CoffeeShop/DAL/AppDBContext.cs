using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.DAL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions opt):base(opt)
        {
            
        }
        public DbSet<Category> categories {  get; set; }
        public DbSet<Product> products { get; set; }
    }
}
