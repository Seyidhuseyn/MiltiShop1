﻿namespace WebApplication1.Models
{
    public class ProductColor:BaseEntity
    {
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
