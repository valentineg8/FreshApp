using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using FreshApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;

namespace FreshApp.Views
{
    public partial class ProductsPage : ContentPage
    {
        public static readonly BindableProperty AddItemToCartCommandProperty =
            BindableProperty.Create(nameof(AddItemToCartCommand), typeof(ICommand), typeof(ProductsPage), null);
        public ICommand AddItemToCartCommand
        {
            get { return (ICommand)GetValue(AddItemToCartCommandProperty); }
            set { SetValue(AddItemToCartCommandProperty, value); }
        }
        public ProductsPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        async void ProductListControl_ProductAdded(System.Object sender, System.EventArgs e)
        {
            var button = sideBar.FindByName<Button>("cartButton");
            var image = new FFImageLoading.Forms.CachedImage {
                Source = (sender as Product).Photo,
                TranslationY = button.Y,
                WidthRequest = 70,
                HeightRequest = 70,
                TranslationX = button.X + 100,
                DownsampleToViewSize = true,
                Scale = 0
            };
            mainContainer.Children.Add(image);
            await image.ScaleTo(1, 200, Easing.CubicOut);
            await Task.WhenAll(
                image.TranslateTo(button.X + 10, button.Y, 300, Easing.CubicIn),
                image.ScaleTo(0, 300, Easing.CubicIn),
                button.ScaleTo(1.2, 200, Easing.CubicIn)
            );
            await button.ScaleTo(1, 200, Easing.CubicIn);
            if (AddItemToCartCommand != null)
                if (AddItemToCartCommand.CanExecute(null))
                    AddItemToCartCommand.Execute(null);

            mainContainer.Children.Remove(image);

        }

    }
}
