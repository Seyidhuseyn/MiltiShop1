﻿namespace WebApplication1.Models
{
    public class Color:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
    }
}
