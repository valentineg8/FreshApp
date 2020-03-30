using System;
using FreshApp.Models;
using Xamarin.Forms;

namespace FreshApp.Utils
{
    public class ProductsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CarouselProduct { get; set; }
        public DataTemplate ListProduct { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var element = item as ProductSection;
            return element.SectionType == SectionType.Carousel ? CarouselProduct : ListProduct;
        }
    }
}
