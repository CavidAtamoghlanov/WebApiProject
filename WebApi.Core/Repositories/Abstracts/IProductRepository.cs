using WebApi.Core.Entities;

namespace WebApi.Core.Repositories.Abstracts;

public interface IProductRepository : IGenericRepository<Product> 
{
    Task<List<Product>> GetProductWithCategory();
}
