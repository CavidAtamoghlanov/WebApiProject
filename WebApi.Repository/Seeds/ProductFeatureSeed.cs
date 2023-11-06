using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Core.Entities;

namespace WebApi.Repository.Seeds;

public class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
{
    public void Configure(EntityTypeBuilder<ProductFeature> builder)
    {
        builder.HasData(
            new ProductFeature {
                Id=1,
                Color="Kırmızı",
                Height=12,
                Width=15,
                ProductId=1
            },
             new ProductFeature
             {
                 Id = 2,
                 Color = "Kırmızı",
                 Height = 12,
                 Width = 15,
                 ProductId = 2
             }
            );
    }
}
