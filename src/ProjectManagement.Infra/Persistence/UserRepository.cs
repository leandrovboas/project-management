using Microsoft.EntityFrameworkCore;
using ProjectManagement.Core.Repositories;
using ProjectManagement.Core.TableModels;
using ProjectManagement.Infra.Configurations;

namespace ProjectManagement.Infra.Persistence;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context) =>
        _context = context;

    public async Task<List<UserModel>> GetAllUserAsync() => 
        await _context.Users.Select(x => x).ToListAsync<UserModel>();
}
