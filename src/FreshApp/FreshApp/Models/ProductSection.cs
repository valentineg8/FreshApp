using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace FreshApp.Models
{
    public class ProductSection : INotifyPropertyChanged
    {
        public string Title { get; set; }
        public SectionType SectionType { get; set; }
        public List<Product> Items { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

   public enum SectionType
    {
        Carousel,
        List
    }
}
