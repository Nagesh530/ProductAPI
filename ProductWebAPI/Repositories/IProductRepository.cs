using ProductWebAPI.DTOs;

namespace ProductWebAPI.Repositories
{
    public interface IProductRepository
    {
        Task<List<GetProductDto>> GetAll();

        Task<GetProductDto> Get(string color);

        Task<List<GetProductDto>> Add(AddProductDto studioItem);
    }
}
