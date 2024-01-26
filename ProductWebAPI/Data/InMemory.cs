using ProductWebAPI.DomainModels;

namespace ProductWebAPI.Data
{
    public class InMemory
    {
        private readonly List<Product> _products;

        public InMemory()
        {
            _products = new List<Product>
            {
                     new Product
                                 {
                                     Id = 1,
                                     Name = "Smartphone X",
                                     Description = "A high-performance smartphone with advanced features.",
                                     Color = "Black",
                                     Price = 799,
                                     DiscountPercentage = 10.0,
                                     Rating = 4.5,
                                     Stock = 50,
                                     Brand = "TechCo",
                                     Category = "Electronics"
                                 },
                     new Product
                                 {
                                     Id = 2,
                                     Name = "Laptop Pro",
                                     Description = "Powerful laptop for multitasking and productivity.",
                                     Color = "Silver",
                                     Price = 1299,
                                     DiscountPercentage = 5.0,
                                     Rating = 4.8,
                                     Stock = 30,
                                     Brand = "TechMega",
                                     Category = "Electronics"
                                 },
                     new Product
                                 {
                                     Id = 3,
                                     Name = "Fitness Tracker",
                                     Description = "Track your fitness activities with this advanced tracker.",
                                     Color = "Blue",
                                     Price = 99,
                                     DiscountPercentage = 15.0,
                                     Rating = 4.2,
                                     Stock = 100,
                                     Brand = "FitLife",
                                     Category = "Fitness"
                                 },
                     new Product
                                 {
                                     Id = 4,
                                     Name = "Wireless Earbuds",
                                     Description = "High-quality wireless earbuds for immersive audio experience.",
                                     Color = "White",
                                     Price = 79,
                                     DiscountPercentage = 8.0,
                                     Rating = 4.0,
                                     Stock = 80,
                                     Brand = "SoundBeats",
                                     Category = "Electronics"
                                 },
                     new Product
                                 {
                                     Id = 5,
                                     Name = "Gaming Mouse",
                                     Description = "Precision gaming mouse with customizable buttons.",
                                     Color = "Red",
                                     Price = 49,
                                     DiscountPercentage = 12.0,
                                     Rating = 4.5,
                                     Stock = 40,
                                     Brand = "GameMaster",
                                     Category = "Gaming"
                                 },
                     new Product
                                 {
                                     Id = 6,
                                     Name = "Coffee Maker",
                                     Description = "Automatic coffee maker for brewing your favorite drinks.",
                                     Color = "Black",
                                     Price = 129,
                                     DiscountPercentage = 5.0,
                                     Rating = 4.2,
                                     Stock = 60,
                                     Brand = "BrewMatic",
                                     Category = "Appliances"
                                 },
                     new Product
                                 {
                                     Id = 7,
                                     Name = "Running Shoes",
                                     Description = "Comfortable running shoes for your active lifestyle.",
                                     Color = "Gray",
                                     Price = 89,
                                     DiscountPercentage = 10.0,
                                     Rating = 4.8,
                                     Stock = 50,
                                     Brand = "RunFlex",
                                     Category = "Footwear"
                                 },
                     new Product
                                 {
                                     Id = 8,
                                     Name = "Bluetooth Speaker",
                                     Description = "Portable Bluetooth speaker for music on the go.",
                                     Color = "Blue",
                                     Price = 69,
                                     DiscountPercentage = 15.0,
                                     Rating = 4.3,
                                     Stock = 70,
                                     Brand = "AudioWave",
                                     Category = "Electronics"
                                 }
            };
        }

        public List<Product> GetInMemoryData() => _products;
    }
}
