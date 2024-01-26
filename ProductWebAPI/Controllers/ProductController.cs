using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductWebAPI.DTOs;
using ProductWebAPI.Repositories;

namespace ProductWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ProductController : ControllerBase
    {
        #region variables 

        private readonly IProductRepository _productRepository;

        #endregion

        #region Constructor 
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            
        }
        #endregion

        #region Methods

        [HttpGet("Products")]
        public async Task<IActionResult> Get()
        {
            var products = await _productRepository.GetAll();
            return Ok(products);
        }

        [HttpGet("{color}")]
        public async Task<IActionResult> GetByColor(string color)
        {
            var product = await _productRepository.Get(color);
            if (product != null)
            {
                return Ok(product);
            }
            else
            {
                return NotFound($"No product found with color '{color}'.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddProductDto product)
        {
            var addedproduct = await _productRepository.Add(product);
            
            if (addedproduct != null)
            {
                return Ok($"New product added successfully");
            }
            else
            {
                return NotFound($"Failed to add new product");
            }
        }
        #endregion
    }
}
