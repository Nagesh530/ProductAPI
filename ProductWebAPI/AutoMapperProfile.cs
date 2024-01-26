using AutoMapper;
using ProductWebAPI.DomainModels;
using ProductWebAPI.DTOs;

namespace ProductWebAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, GetProductDto>();          
            CreateMap<AddProductDto, Product>();
        }
    }
}
