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
        private readonly IService<Product> _productService;

        public ProductsController(IMapper mapper, IService<Product> productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _productService.GetAllAsync();
            var productDto = _mapper.Map<IEnumerable<ProductDto>>(products).ToList();

            //return Ok(CustomResponseDto<List<ProductDto>>.Success(productDto, 200));
            return CreateActionResult<List<ProductDto>>(CustomResponseDto<List<ProductDto>>.Success(productDto, 200));
        }


        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            var productDto = _mapper.Map<ProductDto>(product);

            //return Ok(CustomResponseDto<List<ProductDto>>.Success(productDto, 200));
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(productDto, 200));
        }


        [HttpPost()]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var product = await _productService.AddAsync(_mapper.Map<Product>(productDto));
            var product_Dto = _mapper.Map<ProductDto>(product);

            //return Ok(CustomResponseDto<List<ProductDto>>.Success(productDto, 200));
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(product_Dto, 201));
        }


        [HttpPut()]
        public async Task<IActionResult> Update(ProductupdateDto productDto)
        {
            await _productService.UpdateAsync(_mapper.Map<Product>(productDto));


            //return Ok(CustomResponseDto<List<ProductDto>>.Success(productDto, 200));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(201));
        }



        [HttpDelete("id")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            await _productService.RemoveAsync(product);


            //return Ok(CustomResponseDto<List<ProductDto>>.Success(productDto, 200));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(201));
        }

    }
}
