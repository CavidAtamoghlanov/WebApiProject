﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Core.Entities;

namespace WebApi.Repository.Seeds;

public class CategorySeed : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category { Id=1, Name="Kalemler"}, 
            new Category { Id = 2, Name = "Defterler" }, 
            new Category { Id = 3, Name = "Kitablar" });
    }
}
