using CRUD_One_To_Many.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CRUD_One_To_Many.DAL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
