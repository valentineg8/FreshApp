using System;
using System.Collections.ObjectModel;
using FreshApp.Models;
using Prism.Mvvm;

namespace FreshApp.ViewModels
{
    public class ProductsPageViewModel : BindableBase
    {
        public ObservableCollection<ProductSection> Products { get; set; }
        public ProductsPageViewModel()
        {
            Products = new ObservableCollection<ProductSection>
            {
                new ProductSection
                {
                    SectionType = SectionType.Carousel,
                    Items = new System.Collections.Generic.List<Product>
                    {
                        new Product
                        {
                            Title = "Apples",
                            Photo = "https://www.konfest.com/wp-content/uploads/2019/07/Konfest-PNG-JPG-Image-Pic-Photo-Free-Download-Royalty-Unlimited-clip-art-sticker-Fruits-Fresh-Eat-Eatable-Vegetables-Food-Apple-Healthy-Greenxial1wuusks863fre7qk.png",
                            Price = 2.5,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
                        },
                        new Product
                        {
                            Title = "Apricot",
                            Photo = "https://cdn.shortpixel.ai/client/q_glossy,ret_img,w_210/https://www.konfest.com/wp-content/uploads/2019/07/Konfest-PNG-JPG-Image-Pic-Photo-Free-Download-Royalty-Unlimited-clip-art-sticker-Fruits-Fresh-Eat-Eatable-Vegetables-Food-Apricot-Peach-Red-Orange-Seed-Healthynijzl2n1ptvdtqr4ydmq.png",
                            Price = 3.5,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
                        },
                        new Product
                        {
                            Title = "Blueberries",
                            Photo = "https://www.konfest.com/wp-content/uploads/2019/06/Konfest-PNG-JPG-Image-Pic-Photo-Free-Download-Royalty-Unlimited-clip-art-sticker-Fruits-Fresh-Eat-Eatable-Vegetables-Food-Berries-Blue-Berry-Juice-Healthy-16.png",
                            Price = 5.5,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
                        }
                    }
                },
                new ProductSection
                {
                    SectionType = SectionType.List,
                    Title = "Popular",
                    Items = new System.Collections.Generic.List<Product>
                    {
                        new Product
                        {
                            Title = "Lemons",
                            Photo = "https://cdn.shortpixel.ai/client/q_glossy,ret_img,w_1000/https://www.konfest.com/wp-content/uploads/2019/06/Konfest-PNG-JPG-Image-Pic-Photo-Free-Download-Royalty-Unlimited-clip-art-sticker-Fruits-Fresh-Eat-Eatable-Vegetables-Food-Lemon-Juice-Juicy-Yellow-4.png",
                            Price = 2.5,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
                        },
                        new Product
                        {
                            Title = "Orange",
                            Photo = "https://www.konfest.com/wp-content/uploads/2019/06/Konfest-PNG-JPG-Image-Pic-Photo-Free-Download-Royalty-Unlimited-clip-art-sticker-Fruits-Fresh-Eat-Eatable-Vegetables-Food-Orange-Juice-Juicy-Healthy-Kinnow-4.png",
                            Price = 5.5,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
                        }
                    }
                }
            };
        }
    }
}
