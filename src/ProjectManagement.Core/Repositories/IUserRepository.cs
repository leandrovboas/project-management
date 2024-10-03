using ProjectManagement.Core.TableModels;

namespace ProjectManagement.Core.Repositories;

public interface IUserRepository
{
    Task<List<UserModel>> GetAllUserAsync();
}
