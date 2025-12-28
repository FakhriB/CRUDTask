using Fiorello.Data;
using Fiorello.Services.Interfaces;
using Fiorello.ViewModels.Category;
using Microsoft.EntityFrameworkCore;

namespace Fiorello.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CategoryVM>> GetAllAdminAsync()
        {
            var categories = await _context.Categories.Select(s => new CategoryVM
            {
                Id = s.Id,
                Name = s.Name,
                CreatedDate = s.CreatedDate
            }).ToListAsync();
            return categories;
        }

        public async Task<IEnumerable<CategoryUIVM>> GetAllAsync()
        {
            var categories = await _context.Categories.Select(s => new CategoryUIVM
            {
                Id = s.Id,
                Name = s.Name
            }).ToListAsync();
            return categories;
        }
    }
}
