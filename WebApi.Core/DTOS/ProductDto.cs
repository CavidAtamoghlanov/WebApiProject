
namespace WebApi.Core.DTOS;

public class ProductDto : BaseDto
{
    public string? Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }


    // Foreign Key
    public int CategoryId { get; set; }
}
