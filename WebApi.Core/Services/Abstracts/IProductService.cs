using WebApi.Core.DTOS;
using WebApi.Core.Entities;

namespace WebApi.Core.Services.Abstracts;

public interface IProductService:IService<Product>
{
    Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductWithCategory();
}
