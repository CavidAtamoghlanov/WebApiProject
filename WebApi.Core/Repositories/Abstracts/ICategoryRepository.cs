using WebApi.Core.Entities;

namespace WebApi.Core.Repositories.Abstracts;

public interface ICategoryRepository : IGenericRepository<Category>
{
    Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId);
}
