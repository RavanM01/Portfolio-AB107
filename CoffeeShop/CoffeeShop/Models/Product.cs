﻿using CoffeeShop.Models.Base;

namespace CoffeeShop.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public string imgUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
