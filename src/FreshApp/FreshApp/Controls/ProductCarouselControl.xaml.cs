using System;
using System.Collections.Generic;
using FreshApp.Models;
using Prism.Commands;
using Xamarin.Forms;

namespace FreshApp.Controls
{
    public partial class ProductCarouselControl : ContentView
    {
        public Func<object> AddProduct { get; set; }
        public static readonly BindableProperty GoToDetailCommandProperty =
          BindableProperty.Create(nameof(GoToDetailCommand), typeof(DelegateCommand<Product>), typeof(ProductCarouselControl));
        public static readonly BindableProperty CurrentCategoryProperty = BindableProperty.Create(nameof(CurrentCategory), typeof(Category), typeof(ProductCarouselControl), new Category());
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
        public ProductCarouselControl()
        {
            InitializeComponent();
        }
    }
}
