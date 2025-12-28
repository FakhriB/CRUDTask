using Fiorello.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;   
        }

        [HttpGet]

        public async Task<IActionResult> Index()
        {
            var results = await _categoryService.GetAllAdminAsync();
            return View(results);
        }
    }
}
