namespace ProductWebAPI.Tests
{
    [TestFixture]
    public class ProductControllerTest
    {
       
        private Mock<IProductRepository> _mockProductRepository;

        [SetUp]
        public void Setup()
        {
            _mockProductRepository = new Mock<IProductRepository>();           
        }

        [Test]
        public async Task Get_ReturnsOkWithProducts_WhenProductsExist()
        {

            List<GetProductDto> products = new List<GetProductDto>() {
                    new GetProductDto
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
                    new GetProductDto
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
                    }
                };

           
            _mockProductRepository.Setup(x => x.GetAll()).ReturnsAsync(products);

            var controller = new ProductController(_mockProductRepository.Object);

            var result = await controller.Get();

            Assert.IsInstanceOf<OkObjectResult>(result);
            Assert.IsNotNull((result as OkObjectResult)?.Value);
        }

        [Test]
        public async Task GetByColor_ReturnsOkWithProduct_WhenProductExists()
        {
            var product = new GetProductDto
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
            };

         
            _mockProductRepository.Setup(x => x.Get(It.IsAny<string>())).ReturnsAsync(product);

            var controller = new ProductController(_mockProductRepository.Object);

            var result = await controller.GetByColor("Blue");

            Assert.IsInstanceOf<OkObjectResult>(result);
            Assert.IsNotNull((result as OkObjectResult)?.Value);
        }

        [Test]
        public async Task GetByColor_ReturnsNotFound_WhenProductDoesNotExist()
        {

            _mockProductRepository.Setup(x => x.Get(It.IsAny<string>())).ReturnsAsync((GetProductDto)null);
            var controller = new ProductController(_mockProductRepository.Object);
            var result = await controller.GetByColor("NoColor");
            Assert.IsInstanceOf<NotFoundObjectResult>(result);
        }

        [Test]
        public async Task Add_ReturnsOkWithAddedProduct_WhenProductIsAdded()
        {

            var product = new AddProductDto
            {
                Id = 10,
                Name = " Tracker",
                Description = " fitness activities.",
                Color = "Red",
                Price = 99,
                DiscountPercentage = 15.0,
                Rating = 4.2,
                Stock = 100,
                Brand = "Life",
                Category = "Life"
            };

            _mockProductRepository.Setup(x => x.Add(It.IsAny<AddProductDto>())).ReturnsAsync(new List<GetProductDto> { new GetProductDto() });
            var controller = new ProductController(_mockProductRepository.Object);

            var result = await controller.Add(product);

            Assert.IsInstanceOf<OkObjectResult>(result);
            Assert.IsNotNull((result as OkObjectResult)?.Value);
        }
    }
}
