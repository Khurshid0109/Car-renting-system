using AutoMapper;
using City_car_rent.Domain.Entities;
using City_car_rent.Service.DTOs.CategoryDto;
using City_car_rent.Service.Helpers;
using City_car_rent.Service.Interfaces;
using City_rent_car.Data.Data;
using City_rent_car.Data.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace City_car_rent.Service.Services;
public class CategoryService : ICategoryService
{
    private readonly DataContext _context;
    private readonly IRepository<Category> _categoryRepository;
    private readonly IMapper _mapper;
    public CategoryService(DataContext context, IMapper mapper, IRepository<Category> categoryRepository)
    {
        _context = context;
        _mapper = mapper;
        _categoryRepository = categoryRepository;
    }
    public async Task<CategoryViewModel> AddAsync(CategoryPostModel dto)
    {
       var category = await _categoryRepository.SelectAll()
            .Where(c =>string.Equals(c.Name.ToLower(),dto.Name.ToLower()))
            .AnyAsync();

        if (category)
            throw new CustomException(409, "CAtegory already exist.");

        var mapped = _mapper.Map<Category>(dto);
        mapped.CreatedAt = DateTime.UtcNow;

        var result = await _categoryRepository.CreateAsync(mapped);
        await _categoryRepository.SaveAsync();

        return _mapper.Map<CategoryViewModel>(result);
    }

    public async Task<bool> DeleteAsync(long id)
    {
       var category = await _categoryRepository.SelectAll()
            .Where (c => c.Id == id)
            .FirstOrDefaultAsync();

        if (category == null)
            throw new CustomException(404, "Category not found.");

        await _categoryRepository.DeleteAsync(id);
        await _categoryRepository.SaveAsync();

        return true;
    }

    public async Task<IEnumerable<CategoryViewModel>> GetAllAsync()
    {
        var categories = await _categoryRepository.SelectAll()
            .AsNoTracking()
            .ToListAsync();

        return _mapper.Map<IEnumerable<CategoryViewModel>>(categories);
    }

    public async Task<CategoryViewModel> GetByIdAsync(long id)
    {
        var category = await _categoryRepository.SelectAll()
             .Where(c => c.Id == id)
             .AsNoTracking()
             .FirstOrDefaultAsync();

        if (category is null)
            throw new CustomException(404, "Customer is not found.");

        return _mapper.Map<CategoryViewModel>(category);
    }

    public async Task<CategoryViewModel> UpdateAsync(long id, CategoryPostModel dto)
    {
        var category = await _categoryRepository.SelectAll()
             .Where(c => c.Id == id)
             .FirstOrDefaultAsync();

        if (category is null)
            throw new CustomException(404, "Customer is not found.");

        var mapped = _mapper.Map(dto, category);
        mapped.UpdatedAt = DateTime.UtcNow;


        var result = await _categoryRepository.UpdateAsync(mapped);
        await _categoryRepository.SaveAsync();
        return _mapper.Map<CategoryViewModel>(result);
    }
}
