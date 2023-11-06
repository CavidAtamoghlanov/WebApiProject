
namespace WebApi.Core.DTOS;

public class ProductFeatureDto
{
    public int Id { get; set; }
    public string Color { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    // Foreign Key
    public int ProductId { get; set; }

}
