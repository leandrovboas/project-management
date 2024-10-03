using AutoMapper;
using ProjectManagement.Application.DTOs;
using ProjectManagement.Core.Entities;
using ProjectManagement.Core.TableModels;

namespace ProjectManagement.Application.AuteMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<UserModel, UserResponse>();
            CreateMap<User, UserResponse>();
        }
    }
}
