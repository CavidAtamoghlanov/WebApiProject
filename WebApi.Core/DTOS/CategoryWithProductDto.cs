using WebApi.Core.Entities;

namespace WebApi.Core.DTOS;

public class CategoryWithProductDto: CategoryDto
{
    public List<ProductDto> Products{ get; set; }
}
