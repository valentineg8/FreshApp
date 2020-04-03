using System;
using System.ComponentModel;

namespace FreshApp.Models
{
    public class Category : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
        public string SoftColor { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
