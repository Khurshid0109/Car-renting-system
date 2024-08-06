using AutoMapper;
using City_car_rent.Domain.Entities;
using City_car_rent.Service.DTOs.CustomerDto;
using City_car_rent.Service.Helpers;
using City_car_rent.Service.Interfaces.Customers;
using City_rent_car.Data.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace City_car_rent.Service.Services.Users;
public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _repository;
    private readonly IMapper _mapper;

    public CustomerService(ICustomerRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<CustomerViewModel> AddAsync(CustomerPostModel dto)
    {
        var user = await _repository.SelectAll()
            .Where(u => u.PhoneNumber == dto.PhoneNumber)
            .AsNoTracking()
            .AnyAsync();

        if (user)
            throw new CustomException(409,"User already exists with this username! Please try another one.");

        var mapped = _mapper.Map<Customer>(dto);
        mapped.CreatedAt = DateTime.UtcNow;

        var result = await _repository.CreateAsync(mapped);
        await _repository.SaveAsync();

        return _mapper.Map<CustomerViewModel>(result);
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var user = await _repository.SelectAll()
            .Where(u => u.Id == id)
            .AnyAsync();

        if (!user)
            throw new CustomException(404, "User is not found.");

        await _repository.DeleteAsync(id);
        await _repository.SaveAsync();

        return true;
    }

    public async Task<IEnumerable<CustomerViewModel>> GetAllAsync()
    {
        var users = await _repository.SelectAll()
            .AsNoTracking()
            .ToListAsync();

        return _mapper.Map<ICollection<CustomerViewModel>>(users);
    }

    public async Task<CustomerViewModel> GetByIdAsync(long id)
    {
        var user = await _repository.SelectAll()
            .Where(u => u.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (user is null)
            throw new CustomException(404, "User is not found.");

        var mapped = _mapper.Map<CustomerViewModel>(user);
        return mapped;
    }

    public async Task<CustomerViewModel> GetByPhoneAsync(string number)
    {
        var user = await _repository.SelectAll()
             .Where(u => u.PhoneNumber.Trim() == number.Trim())
             .AsNoTracking()
             .FirstOrDefaultAsync();

        if (user is null)
            throw new CustomException(404, "User is not found.");

        return _mapper.Map<CustomerViewModel>(user);
    }

    public async Task<CustomerViewModel> UpdateAsync(long id, CustomerPutModel dto)
    {
        var user = await _repository.SelectAll()
            .Where(u => u.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (user is null)
            throw new CustomException(404, "User is not found.");

        var mapped = _mapper.Map(dto,user);
        mapped.UpdatedAt = DateTime.UtcNow;

        await _repository.UpdateAsync(mapped);
        await _repository.SaveAsync();

        return _mapper.Map<CustomerViewModel>(mapped);
    }
}
