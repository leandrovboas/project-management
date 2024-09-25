using ProjectManagement.Application.DTOs;
using ProjectManagement.Core.Entities;

namespace ProjectManagement.Application.UseCases.Interface;

public interface IGetUserUseCase
{
    Task<List<UserResponse>> ExecuteAsync();
}
