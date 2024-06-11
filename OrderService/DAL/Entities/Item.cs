﻿namespace OrderService.DAL.Entities
{
    public class Item : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}