using Microsoft.EntityFrameworkCore;
using WebApi.Core.Entities;
using WebApi.Core.Repositories.Abstracts;
using WebApi.Repository.Contexts;

namespace WebApi.Repository.Repositories.Concrets;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context){}

    public async Task<List<Product>> GetProductWithCategory()
    {
        // Eager Loading
       return await _context.Products.Include(p => p.Category).ToListAsync();
    }
}
