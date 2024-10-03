using AutoMapper;
using ProjectManagement.Application.DTOs;
using ProjectManagement.Core.Repositories;

namespace ProjectManagement.Application.UseCases.User;

public class GetUserUseCase : IGetUserUseCase
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    public GetUserUseCase(IUserRepository userRepository, IMapper mapper) {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<List<UserResponse>> ExecuteAsync()
    {
        var result = await _userRepository.GetAllUserAsync();
        return _mapper.Map<List<UserResponse>>(result);
    }
}
