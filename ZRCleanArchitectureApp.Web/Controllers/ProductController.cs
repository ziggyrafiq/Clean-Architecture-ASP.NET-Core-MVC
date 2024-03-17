using Microsoft.AspNetCore.Mvc;
using ZRCleanArchitectureApp.Application.Services;

namespace ZRCleanArchitectureApp.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProductsAsync();
            return View(products);
        }

        // Add other action methods
    }
}
