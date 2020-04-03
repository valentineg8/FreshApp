using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using FreshApp.Models;
using FreshApp.Utils;
using FreshApp.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace FreshApp.ViewModels
{
    public class ProductsPageViewModel : ViewModelBase
    {
        public ObservableCollection<ProductSection> Products { get; set; }
        public Category CurrentCategory { get; set; }
        public ObservableCollection<Category> Categories { get; set; }
        public int CartItems { get; set; }
        public bool IsProductsLoading { get; set; }
        public string SelectedProductId { get; set; }
        public DelegateCommand<Product> GoToDetailCommand { get; set; }
        public DelegateCommand<Category> CurrentCategoryChangedCommand { get; set; }
        public DelegateCommand AddItemToCartCommand { get; set; }
        public ProductsPageViewModel(INavigationService navigationPage): base(navigationPage)
        {
            GoToDetailCommand = new DelegateCommand<Product>(GoToDetail);
            
            Products = new ObservableCollection<ProductSection>();
            AddItemToCartCommand = new DelegateCommand(() => CartItems++);
            CurrentCategoryChangedCommand = new DelegateCommand<Category>(c => LoadData());
            Categories = new ObservableCollection<Category>
            {
                new Category
                {
                    Id = 1,
                    Title = "Meat",
                    Icon = "meat.png",
                    Color = "#9d0b0b",
                    SoftColor = "#fde8e7",

                },
                new Category
                {
                    Id = 2,
                    Title = "Vegetables",
                    Icon = "vegetable.png",
                    Color = "#5a9f61",
                    SoftColor = "#e9f4eb"
                },
                new Category
                {
                    Id = 3,
                    Title = "Fruits",
                    Icon = "fruit.png",
                    Color = "#363062",
                    SoftColor = "#e6e3fb"
                },
                new Category
                {
                    Id = 4,
                    Title = "Food",
                    Icon = "food.png",
                    Color = "#003f5c",
                    SoftColor = "#d9f2fd"

                },
            };


        }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.GetNavigationMode() != NavigationMode.Back)
            {
                LoadData();
                CurrentCategory = Categories.FirstOrDefault();
            }
        }

        async void LoadData()
        {
            IsProductsLoading = true;

            Products.Clear();
            await Task.Delay(1000);

            Products = new ObservableCollection<ProductSection>
            {
                new ProductSection
                {
                    SectionType = SectionType.Carousel,
                    Items = new List<Product>(Data.Products.Where(e => e.CategoryId == CurrentCategory.Id && e.IsFeatured))
                },
                new ProductSection
                {
                    SectionType = SectionType.List,
                    Title = "Popular",
                    Items = new List<Product>(Data.Products.Where(e => e.CategoryId == CurrentCategory.Id && !e.IsFeatured))

                }
            };
            IsProductsLoading = false;
        }
        async void GoToDetail(Product product)
        {
            SelectedProductId = product.Id;
            var navParam = new NavigationParameters { { nameof(product), product }, { nameof(CurrentCategory), CurrentCategory } };
            await NavigationService.NavigateAsync($"{nameof(ProductDetailPage)}", navParam);
        }
    }
}
