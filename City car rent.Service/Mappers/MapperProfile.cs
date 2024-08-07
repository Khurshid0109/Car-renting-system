using AutoMapper;
using City_car_rent.Domain.Entities;
using City_car_rent.Service.DTOs.CategoryDto;
using City_car_rent.Service.DTOs.CustomerDto;

namespace City_car_rent.Service.Mappers;
public class MapperProfile:Profile
{
    public MapperProfile()
    {
        //Customer
        CreateMap<Customer, CustomerPostModel>().ReverseMap();
        CreateMap<Customer, CustomerPutModel>().ReverseMap();
        CreateMap<Customer, CustomerViewModel>().ReverseMap();
        //Category
        CreateMap<Category, CategoryPostModel>().ReverseMap();
        CreateMap<Category, CategoryViewModel>().ReverseMap();
    }
}