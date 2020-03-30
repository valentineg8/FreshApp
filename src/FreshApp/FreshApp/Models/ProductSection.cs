using System;
using System.Collections.Generic;

namespace FreshApp.Models
{
    public class ProductSection
    {
        public string Title { get; set; }
        public SectionType SectionType { get; set; }
        public List<Product> Items { get; set; }
    }

   public enum SectionType
    {
        Carousel,
        List
    }
}
