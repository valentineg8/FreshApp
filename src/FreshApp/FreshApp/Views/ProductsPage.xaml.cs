using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PancakeView;

namespace FreshApp.Views
{
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
    }
}
