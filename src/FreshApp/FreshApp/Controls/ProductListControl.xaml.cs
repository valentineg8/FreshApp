using System;
using System.Collections.Generic;
using FreshApp.Models;
using Prism.Commands;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;

namespace FreshApp.Controls
{
    public partial class ProductListControl : ContentView
    {
        public event EventHandler ProductAdded;
        public static readonly BindableProperty GoToDetailCommandProperty =
          BindableProperty.Create(nameof(GoToDetailCommand), typeof(DelegateCommand<Product>), typeof(ProductListControl));

        public static readonly BindableProperty CurrentCategoryProperty = BindableProperty.Create(nameof(CurrentCategory), typeof(Category), typeof(ProductListControl), new Category());
        public Category CurrentCategory
        {
            get { return (Category)GetValue(CurrentCategoryProperty); }
            set { SetValue(CurrentCategoryProperty, value); }
        }
        public DelegateCommand<Product> GoToDetailCommand
        {
            get { return (DelegateCommand<Product>)GetValue(GoToDetailCommandProperty); }
            set { SetValue(GoToDetailCommandProperty, value); }
        }
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
