using Fiorello.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var results = await _productService.GetAllAdminAsync();
            return View(results);
        }
    }
}