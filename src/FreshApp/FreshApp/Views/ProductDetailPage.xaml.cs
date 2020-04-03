using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FreshApp.Views
{
    public partial class ProductDetailPage : ContentPage
    {
        public ProductDetailPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
