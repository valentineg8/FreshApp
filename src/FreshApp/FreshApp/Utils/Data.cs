using System;
using System.Collections.Generic;
using FreshApp.Models;

namespace FreshApp.Utils
{
    public static class Data
    {
        public static List<Product> Products = new List<Product>
        {

            new Product
            {
                Title = "Green Apples",
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32350-green-apple-icon.png",
                Price = 5.5,
                IsFeatured = true,
                CategoryId = 3,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
            new Product
            {
                Title = "Banana",
                Photo = "https://cdn.shortpixel.ai/client/q_glossy,ret_img,w_1211/https://www.konfest.com/wp-content/uploads/2019/07/Konfest-PNG-JPG-Image-Pic-Photo-Free-Download-Royalty-Unlimited-clip-art-sticker-Fruits-Fresh-Eat-Eatable-Vegetables-Food-Banana-Healthy-Yellow6mxew1sksmhl184twke1.png",
                Price = 3.5,
                IsFeatured = true,
                CategoryId = 3,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
            new Product
            {
                Title = "Grapes",
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32341-grapes-icon.png",
                Price = 5.5,
                IsFeatured = true,
                CategoryId = 3,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
            new Product
            {
                Title = "Melon",
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32342-melon-icon.png",
                Price = 3.5,
                CategoryId = 3,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
            new Product
            {
                Title = "Lemons",
                Photo = "https://icons.iconarchive.com/icons/google/noto-emoji-food-drink/512/32345-lemon-icon.png",
                Price = 2.5,
                CategoryId = 3,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
            new Product
            {
                Title = "Orange",
                Photo = "https://icons.iconarchive.com/icons/gcds/chinese-new-year/512/orange-icon.png",
                Price = 5.5,
                CategoryId = 3,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },


            new Product
            {
                Title = "Meat on bone",
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32378-meat-on-bone-icon.png",
                Price = 11.5,
                CategoryId = 1,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
            new Product
            {
                Title = "Cut of meat",
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32380-cut-of-meat-icon.png",
                Price = 5.5,
                CategoryId = 1,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
            new Product
            {
                Title = "Bacon",
                IsFeatured = true,
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32381-bacon-icon.png",
                Price = 10.5,
                CategoryId = 1,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },


            new Product
            {
                Title = "Eggplant",
                IsFeatured = true,
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32359-eggplant-icon.png",
                Price = 5.5,
                CategoryId = 2,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
            new Product
            {
                Title = "Potato",
                IsFeatured = true,
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32360-potato-icon.png",
                Price = 5.5,
                CategoryId = 2,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
            new Product
            {
                Title = "Broccoli",
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32367-broccoli-icon.png",
                Price = 5.5,
                CategoryId = 2,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
            new Product
            {
                Title = "Cucumber",
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32365-cucumber-icon.png",
                Price = 5.5,
                CategoryId = 2,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },


            new Product
            {
                Title = "Hamburger",
                IsFeatured = true,
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32382-hamburger-icon.png",
                Price = 15.5,
                CategoryId = 4,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
            new Product
            {
                Title = "Pizza",
                IsFeatured = true,
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32384-pizza-icon.png",
                Price = 15.5,
                CategoryId = 4,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
            new Product
            {
                Title = "Hot Dog",
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32385-hot-dog-icon.png",
                Price = 10.5,
                CategoryId = 4,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
            new Product
            {
                Title = "Sandwich",
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32386-sandwich-icon.png",
                Price = 8.5,
                CategoryId = 4,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
            new Product
            {
                Title = "Taco",
                Photo = "http://icons.iconarchive.com/icons/google/noto-emoji-food-drink/256/32387-taco-icon.png",
                Price = 8.5,
                CategoryId = 4,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tellus lacus, scelerisque quis suscipit id, ultrices ac dui. Sed vehicula cursus vulputate. Morbi tempor hendrerit lorem et faucibus. Aenean finibus nisi lacus, id faucibus nisl egestas id. Sed venenatis nibh elit, vitae rhoncus nulla congue vitae. Vivamus ut nibh sit amet mauris imperdiet aliquam non eu est. Praesent consequat consectetur ipsum, in pellentesque odio lacinia quis. Proin id nisi sit amet urna posuere viverra et vel diam."
            },
        };
    }
}
