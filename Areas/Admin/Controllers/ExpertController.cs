using Fiorello.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExpertController : Controller
    {
        private readonly IExpertService _expertService;
        public ExpertController(IExpertService expertService)
        {
            _expertService = expertService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var results = await _expertService.GetAllAdminAsync();
            return View(results);
        }
    }
}