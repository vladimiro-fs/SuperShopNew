namespace SuperShopNew.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using SuperShopNew.Data;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts() 
        {
            return Ok(_productRepository.GetAllWithUsers());
        }
    }
}
