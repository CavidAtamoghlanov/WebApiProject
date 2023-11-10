using AutoMapper;
using WebApi.Core.DTOS;
using WebApi.Core.Entities;
using WebApi.Core.Repositories.Abstracts;
using WebApi.Core.Services.Abstracts;
using WebApi.Core.UnitOfWorks;

namespace WebApi.Service.Services.Concrets;

public class ProductService : Service<Product>, IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
    {

        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<CustomResponseDto<List<ProductWithCategoryDto>> >GetProductWithCategory()
    {
        var products = await _productRepository.GetProductWithCategory();
        var productsDto = _mapper.Map<List<ProductWithCategoryDto>>(products);
        return CustomResponseDto<List<ProductWithCategoryDto>>.Success(productsDto,200);
    }
}
