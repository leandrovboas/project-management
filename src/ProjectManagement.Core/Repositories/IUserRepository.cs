using ProjectManagement.Core.Entities;

namespace ProjectManagement.Core.Repositories;

public interface IUserRepository
{
    Task<List<User>> GetAllUserAsync();
}
