using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Core.DTOS;
using WebApi.Core.Entities;
using WebApi.Core.Services.Abstracts;

namespace WebApi.API.Controllers
{
    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;
   
        private readonly IProductService service;

        public ProductsController(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
          ;
            service = productService;
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductsWithCategory()
        {
            return CreateActionResult(await service.GetProductWithCategory());
        }




        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await service.GetAllAsync();
            var productDto = _mapper.Map<IEnumerable<ProductDto>>(products).ToList();

            //return Ok(CustomResponseDto<List<ProductDto>>.Success(productDto, 200));
            return CreateActionResult<List<ProductDto>>(CustomResponseDto<List<ProductDto>>.Success(productDto, 200));
        }


        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await service.GetByIdAsync(id);
            var productDto = _mapper.Map<ProductDto>(product);

            return CreateActionResult(CustomResponseDto<ProductDto>.Success(productDto, 200));
        }


        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var product = await service.AddAsync(_mapper.Map<Product>(productDto));
            var product_Dto = _mapper.Map<ProductDto>(product);

            return CreateActionResult(CustomResponseDto<ProductDto>.Success(product_Dto, 201));
        }


        [HttpPut]
        public async Task<IActionResult> Update(ProductupdateDto productDto)
        {
            await service.UpdateAsync(_mapper.Map<Product>(productDto));


            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(201));
        }



        [HttpDelete("id")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await service.GetByIdAsync(id);
            await service.RemoveAsync(product);


            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(201));
        }

    }
}
