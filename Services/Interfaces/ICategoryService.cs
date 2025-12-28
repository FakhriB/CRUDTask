using Fiorello.ViewModels.Category;

namespace Fiorello.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryUIVM>> GetAllAsync();
        Task<IEnumerable<CategoryVM>> GetAllAdminAsync();

    }
}
