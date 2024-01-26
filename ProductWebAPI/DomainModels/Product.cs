namespace ProductWebAPI.DomainModels
{
    public class Product
    {      
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }
        public int Price { get; set; }
        public double DiscountPercentage { get; set; }
        public double Rating { get; set; }
        public int Stock { get; set; }
        public string? Brand { get; set; }
        public string? Category { get; set; }
    }
}
