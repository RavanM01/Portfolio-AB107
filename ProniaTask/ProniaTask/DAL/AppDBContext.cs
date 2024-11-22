﻿using Microsoft.EntityFrameworkCore;
using ProniaTask.Models;

namespace ProniaTask.DAL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Slider> sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagProduct> TagProducts  { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

    }
}