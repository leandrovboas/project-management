using ProjectManagement.Application.DTOs;
using ProjectManagement.Core.Entities;

namespace ProjectManagement.Application.UseCases.User;

public interface IGetUserUseCase
{
    Task<List<UserResponse>> ExecuteAsync();
}
