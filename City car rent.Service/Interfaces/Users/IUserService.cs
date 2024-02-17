using City_car_rent.Service.DTOs.UserDtos;

namespace City_car_rent.Service.Interfaces.Users;
public interface IUserService
{
    Task<UserViewModel> GetByIdAsync(long id);
    Task<UserViewModel> GetByUserNameAsync(string userName);
    Task<IEnumerable<UserViewModel>> GetAllAsync();
    Task<UserViewModel> AddAsync(UserPostModel dto);
    Task<UserViewModel> UpdateAsync(long id, UserPutModel dto);
    Task<bool> DeleteAsync(long id);
}
