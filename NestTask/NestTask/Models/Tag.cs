﻿using NestTask.Models.Base;

namespace NestTask.Models
{
    public class Tag:BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
