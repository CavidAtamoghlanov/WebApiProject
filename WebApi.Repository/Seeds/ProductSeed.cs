using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Core.Entities;

namespace WebApi.Repository.Seeds;

public class ProductSeed : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(
            new Product
            {

                Id = 1,
                CategoryId = 1,
                Price = 200,
                Stock = 20,
                CreatedDate = DateTime.Now,
                Name = "Product 1"


            },
                 new Product
                 {

                  Id = 2,
                  CategoryId = 2,
                  Price = 300,
                  Stock = 30,
                  CreatedDate = DateTime.Now,
                  Name = "Product 2"


              },
                 new Product
                 {

                    Id = 3,
                    CategoryId = 2,
                    Price = 200,
                    Stock = 20,
                    CreatedDate = DateTime.Now,
                    Name = "Product 3"


                }
            );
    }
}
