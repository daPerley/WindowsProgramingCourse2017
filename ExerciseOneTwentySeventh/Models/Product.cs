using System.Collections.Generic;

namespace ExerciseOneTwentySeventh.Models
{
    class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public static List<Product> GetProducts()
        {
            var products = new List<Product>() {
                new Product()
                {
                    Id=1,
                    Title ="Oligio Mint Choclate Chip",
                    Price=15
                },
                new Product()
                {
                    Id=1,
                    Title ="Oligio Cookies and Cream",
                    Price=15
                },
                new Product()
                {
                    Id=1,
                    Title ="Oligio Banana Caramell",
                    Price=15
                }
            };

            return products;
        }
    }
}
