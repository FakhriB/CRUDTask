using Fiorello.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderInfoController : Controller
    {
        private readonly ISliderInfoService _sliderInfoService;
        public SliderInfoController(ISliderInfoService sliderInfoService)
        {
            _sliderInfoService = sliderInfoService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var results = await _sliderInfoService.GetInfoAdminAsync();

            return View(results);
        }
    }
}