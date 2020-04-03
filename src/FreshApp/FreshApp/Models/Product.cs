using System;
using System.ComponentModel;

namespace FreshApp.Models
{
    public class Product : INotifyPropertyChanged
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public bool IsFeatured { get; set; }
        public double Price { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
