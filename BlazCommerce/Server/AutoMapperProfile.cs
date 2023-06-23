using AutoMapper;
using BlazCommerce.Server.Data;

namespace BlazCommerce.Server
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<NewProduct, Product>();
            CreateMap<Product, ProductEntity>().ReverseMap();
        }
    }
}
