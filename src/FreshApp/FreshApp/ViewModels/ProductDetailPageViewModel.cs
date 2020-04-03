using System;
using System.ComponentModel;
using FreshApp.Models;
using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;

namespace FreshApp.ViewModels
{
    public class ProductDetailPageViewModel : ViewModelBase, IAutoInitialize
    {
        public Product Product { get; set; }
        public Category CurrentCategory { get; set; }
        public ProductDetailPageViewModel(INavigationService navigationPage) : base(navigationPage)
        {
        }
    }
}
