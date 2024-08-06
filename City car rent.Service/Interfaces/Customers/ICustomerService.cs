using City_car_rent.Service.DTOs.CustomerDto;

namespace City_car_rent.Service.Interfaces.Customers;
public interface ICustomerService
{
    Task<CustomerViewModel> GetByIdAsync(long id);
    Task<CustomerViewModel> GetByPhoneAsync(string userName);
    Task<IEnumerable<CustomerViewModel>> GetAllAsync();
    Task<CustomerViewModel> AddAsync(CustomerPostModel dto);
    Task<CustomerViewModel> UpdateAsync(long id, CustomerPutModel dto);
    Task<bool> DeleteAsync(long id);
}