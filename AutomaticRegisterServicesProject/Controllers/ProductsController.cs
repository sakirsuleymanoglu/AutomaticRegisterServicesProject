using AutomaticRegisterServicesProject.Abstracts.Products;
using AutomaticRegisterServicesProject.Concretes.WithoutAbstract;
using Microsoft.AspNetCore.Mvc;

namespace AutomaticRegisterServicesProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        readonly IProductService _productService;
        readonly ProductWithoutAbstractService _productWithoutAbstractService;

        public ProductsController(IProductService productService, ProductWithoutAbstractService productWithoutAbstractService)
        {
            _productService = productService;
            _productWithoutAbstractService = productWithoutAbstractService;
        }


        [HttpGet("withabstract")]
        public IActionResult WithAbstract()
        {
            return Ok(_productService.GetProducts());
        }


        [HttpGet("withoutabstract")]
        public IActionResult WithoutAbstract()
        {
            return Ok(_productWithoutAbstractService.GetProductById(4));
        }
    }
}
