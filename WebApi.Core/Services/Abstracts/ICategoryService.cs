using WebApi.Core.DTOS;
using WebApi.Core.Entities;

namespace WebApi.Core.Services.Abstracts;

public interface ICategoryService:IService<Category>
{
  Task<CustomResponseDto<CategoryWithProductDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);

}
