using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FreshApp.Models;
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

        async void ProductListControl_ProductAdded(System.Object sender, System.EventArgs e)
        {
            mainContainer.Children.Clear();
            var button = sideBar.FindByName<Button>("cartButton");
            mainContainer.Children.Add(new Image { Source = (sender as Product).Photo });
            mainContainer.TranslationY = button.Y;
            mainContainer.TranslationX = button.X + 100;
            mainContainer.Scale = 0;
            await mainContainer.ScaleTo(1, 200, Easing.CubicOut);
            await Task.WhenAll(
                mainContainer.TranslateTo(button.X + 10, button.Y, 300, Easing.CubicIn),
                mainContainer.ScaleTo(0, 300, Easing.CubicIn)
            );
            await button.ScaleTo(1.2, 200, Easing.CubicIn);
            await button.ScaleTo(1, 200, Easing.CubicIn);

        }

    }
}
