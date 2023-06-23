using AutoMapper;
using BlazCommerce.Server.Data;

namespace BlazCommerce.Server
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<NewProduct, ProductEntity>();
            CreateMap<Product, ProductEntity>().ReverseMap();
        }
    }
}
