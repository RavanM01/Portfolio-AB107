﻿using LittleFashion.Models;
using Microsoft.EntityFrameworkCore;

namespace LittleFashion.DAL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
