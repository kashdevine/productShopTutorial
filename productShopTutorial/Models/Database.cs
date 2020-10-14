using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productShopTutorial.Models
{
    public class Database
    {
         public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    Name = "Product 1",
                    Price = (decimal) 499.00
                },
                new Product {
                    ProductID= 2,
                    Name = "Best product ever",
                    Price= (decimal) 1109.00
                },
                new Product {
                    ProductID= 3,
                    Name = "Third product",
                    Price= (decimal) 1109.97
                },
                new Product {
                    ProductID= 4,
                    Name = "Product of the month",
                    Price= (decimal) 119.30
                },
                new Product {
                    ProductID= 5,
                    Name = "Fifth product",
                    Price= (decimal) 18.29
                },
                new Product {
                    ProductID= 6,
                    Name = "Product again",
                    Price= (decimal) 599.99
                },
                new Product {
                    ProductID= 7,
                    Name = "The lucky Product",
                    Price= (decimal) 899.55
                },
                new Product {
                    ProductID= 8,
                    Name = "The holy Product",
                    Price= (decimal) 488.45
                },
                new Product {
                    ProductID= 9,
                    Name = "Nein Product",
                    Price= (decimal) 1.22
                },
                new Product {
                    ProductID= 10,
                    Name = "Finale",
                    Price= (decimal) 98.65
                }
            };
            return products;
         }

        public static Product GetProduct(string slug)
        {
            List<Product> products = Database.GetProducts();
            foreach(Product p in products)
            {
                if (p.Slug == slug)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
