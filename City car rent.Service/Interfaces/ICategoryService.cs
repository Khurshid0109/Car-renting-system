using City_car_rent.Service.DTOs.CategoryDto;

namespace City_car_rent.Service.Interfaces;
public interface ICategoryService
{
    Task<CategoryViewModel> GetByIdAsync(long id);
    Task<IEnumerable<CategoryViewModel>> GetAllAsync();
    Task<CategoryViewModel> AddAsync(CategoryPostModel dto);
    Task<CategoryViewModel> UpdateAsync(long id, CategoryPostModel dto);
    Task<bool> DeleteAsync(long id);
}
