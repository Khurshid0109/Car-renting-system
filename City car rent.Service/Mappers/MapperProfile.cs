using AutoMapper;
using City_car_rent.Domain.Entities;
using City_car_rent.Service.DTOs.UserDtos;

namespace City_car_rent.Service.Mappers;
public class MapperProfile:Profile
{
    public MapperProfile()
    {
        CreateMap<User, UserPostModel>().ReverseMap();
        CreateMap<User,UserPutModel>().ReverseMap();
        CreateMap<User,UserViewModel>().ReverseMap();
    }
}

