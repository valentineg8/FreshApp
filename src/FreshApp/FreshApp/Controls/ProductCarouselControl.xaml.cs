using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FreshApp.Controls
{
    public partial class ProductCarouselControl : ContentView
    {
        public Func<object> AddProduct { get; set; }
        public ProductCarouselControl()
        {
            InitializeComponent();
        }
    }
}
