using Microsoft.EntityFrameworkCore;
using WebApi.Core.Entities;
using WebApi.Core.Repositories.Abstracts;
using WebApi.Repository.Contexts;

namespace WebApi.Repository.Repositories.Concrets;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {}

    public async Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId)
    {
        return await _context.Categories.Include(x => x.Products).Where(x=>x.Id == categoryId).SingleOrDefaultAsync();
    }
}
