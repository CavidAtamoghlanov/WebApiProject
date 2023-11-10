using AutoMapper;
using WebApi.Core.DTOS;
using WebApi.Core.Entities;
using WebApi.Core.Repositories.Abstracts;
using WebApi.Core.Services.Abstracts;
using WebApi.Core.UnitOfWorks;

namespace WebApi.Service.Services.Concrets;

public class CategoryService : Service<Category>, ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, ICategoryRepository categoryRepository, IMapper mapper) : base(repository, unitOfWork)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<CustomResponseDto<CategoryWithProductDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId)
    {
        var category = await _categoryRepository.GetSingleCategoryByIdWithProductsAsync(categoryId);

        var categoryDto = _mapper.Map<CategoryWithProductDto>(category);

        return CustomResponseDto<CategoryWithProductDto>.Success(categoryDto, 200);
    }
}
