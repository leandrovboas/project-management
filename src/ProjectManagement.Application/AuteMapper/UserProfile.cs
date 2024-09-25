using AutoMapper;
using ProjectManagement.Application.DTOs;
using ProjectManagement.Core.Entities;

namespace ProjectManagement.Application.AuteMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserResponse>();
        }
    }
}
