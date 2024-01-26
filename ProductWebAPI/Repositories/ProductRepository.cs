using Microsoft.Extensions.Diagnostics.HealthChecks;
using ProductWebAPI.Data;
using ProductWebAPI.DomainModels;
using ProductWebAPI.DTOs;

namespace ProductWebAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            _products = new InMemory().GetInMemoryData();
        }

        public Task<List<GetProductDto>> GetAll()
        {
            var _mapper = Common.CreateMapper();

            return Task.Run(() => _products.Select(x => _mapper.Map<GetProductDto>(x)).ToList());
        }

        public Task<GetProductDto> Get(string color)
        {
            var _mapper = Common.CreateMapper();

            Product? product = _products.FirstOrDefault(c => c.Color == color);

            if (product != null)
            {
                return Task.Run(() => _mapper.Map<GetProductDto>(product));
            }
            else
            {
                return Task.Run(() => _mapper.Map<GetProductDto>(null));
            }
        }

        public Task<List<GetProductDto>> Add(AddProductDto productDto)
        {
            var _mapper = Common.CreateMapper();          
            _products.Add(_mapper.Map<Product>(productDto));         
            return Task.Run(() => _products.Select(x => _mapper.Map<GetProductDto>(x)).ToList());
        }
    }
}
