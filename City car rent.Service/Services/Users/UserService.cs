using AutoMapper;
using City_car_rent.Domain.Entities;
using City_car_rent.Service.Helpers;
using Microsoft.EntityFrameworkCore;
using City_rent_car.Data.IRepositories;
using City_car_rent.Service.DTOs.UserDtos;
using City_car_rent.Service.Interfaces.Users;

namespace City_car_rent.Service.Services.Users;
public class UserService : IUserService
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<UserViewModel> AddAsync(UserPostModel dto)
    {
        var user = await _repository.SelectAll()
            .Where(u => u.Username.ToLower() == dto.Username.ToLower())
            .AsNoTracking()
            .AnyAsync();

        if (user)
            throw new CustomException("User already exists with this username! Please try another one.");

        var mapped = _mapper.Map<User>(dto);
        mapped.CreatedAt = DateTime.UtcNow;

        var result = await _repository.CreateAsync(mapped);
        await _repository.SaveAsync();

        return _mapper.Map<UserViewModel>(result);
    }

    public Task<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserViewModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UserViewModel> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<UserViewModel> GetByUserNameAsync(string userName)
    {
        throw new NotImplementedException();
    }

    public Task<UserViewModel> UpdateAsync(long id, UserPutModel dto)
    {
        throw new NotImplementedException();
    }
}
