using Microsoft.EntityFrameworkCore;
using ProjectManagement.Core.Entities;
using ProjectManagement.Core.Repositories;
using ProjectManagement.Infra.Configurations;

namespace ProjectManagement.Infra.Persistence;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context) =>
        _context = context;

    public async Task<List<User>> GetAllUserAsync() => 
        await _context.Users.Select(x => x).ToListAsync<User>();
}
