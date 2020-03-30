using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;

namespace FreshApp.Controls
{
    public partial class ProductListControl : ContentView
    {
        public event EventHandler ProductAdded;
        public ProductListControl()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var parent = (sender as Button).Parent as Grid;
            
            ProductAdded.Invoke(parent.BindingContext, new EventArgs());
        }
    }
}
