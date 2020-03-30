using System;
namespace FreshApp.Models
{
    public class Product
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public double Price { get; set; }
    }
}
