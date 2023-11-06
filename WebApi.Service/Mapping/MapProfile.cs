using AutoMapper;
using WebApi.Core.DTOS;
using WebApi.Core.Entities;

namespace WebApi.Service.Mapping;

public class MapProfile:Profile
{
    public MapProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Product, ProductupdateDto>().ReverseMap();
        CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();
     
       

    }
}
