namespace WebApi.Core.DTOS;

public class ProductWithCategoryDto : ProductDto
{
    public CategoryDto Category { get; set; }
}
