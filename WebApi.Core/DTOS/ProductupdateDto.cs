namespace WebApi.Core.DTOS;

public class ProductupdateDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }


    // Foreign Key
    public int CategoryId { get; set; }
}
