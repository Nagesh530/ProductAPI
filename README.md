
********************************** Nagesh Duggempudi ********************************************

Implemented Functionality:-

1. Health Check Endpoint:

    Implemented a health check endpoint providing a status response.

2. Secured Endpoints:

   Ensured security for endpoints:

     Retrieving all products.
     Retrieving products by color.
     Adding a new product.

3. In-Memory Data Storage:

    Established an in-memory data source, housing a collection of sample products.

4. Comprehensive Testing:

    Implemented robust unit tests covering health check and product controller actions.

5.HealthCheckController Class:

    [AllowAnonymous] attribute enables anonymous access to the health check endpoint.
    GET /api/health - Health check endpoint providing the cache status.

6.ProductController Class:

    [HttpGet("Products")] - Secured endpoint retrieves a list of all products.
    [HttpGet("{color}")] - Secured endpoint retrieves products of a specific color.
    [HttpPost] - Secured endpoint adds a new product.

7.InMemory Class:

    In-memory data source hosting a curated list of sample products.

Product Class: Defines the fundamental structure of a product.

AddProductDTO Class: Data Transfer Object (DTO)  for adding new products.


GetProductDto Class: DTO designed for retrieving detailed product information.


HealthResult Class: Represents the outcome of a health check, encapsulating status and description.


CacheHealthChecker Class: Implements ICacheHealthChecker, gauging cache health via HealthCheckService.
Generates a HealthResult reflecting the current cache health.


ICacheHealthChecker Interface: Defines the standardized contract for cache health checking.


IProductRepository Interface: Outlines the contract for various product repository operations.


ProductRepository Class: Implements IProductRepository, orchestrating product data management.
Operations encompass retrieving all products, fetching products by color, and adding new products.


AutoMapperProfile Class: Configures AutoMapper mappings, ensuring seamless transitions between different types.


Common Class: Equips a static method facilitating the instantiation of AutoMapper.


Global Usings: Harmonized using statements applied universally across the project.


HealthCheckControllerTest Class: NUnit test suite dedicated to HealthCheckController.
Rigorous testing of the HealthCheck method under both healthy and unhealthy scenarios.


ProductControllerTest Class: NUnit test suite tailored for ProductController.
Thorough examination of the Get, GetByColor, and Add methods.
