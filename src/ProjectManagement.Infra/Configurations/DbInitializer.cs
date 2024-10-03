using Microsoft.EntityFrameworkCore;
using ProjectManagement.Core.Enums;
using ProjectManagement.Core.TableModels;

namespace ProjectManagement.Infra.Configurations;

public class DbInitializer
{
    private readonly ModelBuilder modelBuilder;

    public DbInitializer(ModelBuilder modelBuilder)
    {
        this.modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        modelBuilder.Entity<UserModel>().HasData(
               new UserModel() { 
                   Name = "Leandro Vilas Boas", 
                   AccessType = AccessType.Manager, 
                   Id = Guid.NewGuid(), 
                   Created_At = DateTime.UtcNow
               },
               new UserModel() { 
                   Name = "Thais Vilas Boas", 
                   AccessType = AccessType.Employee ,
                   Id = Guid.NewGuid(),
                   Created_At = DateTime.UtcNow
               },
               new UserModel() { 
                   Name = "Mariana Vilas Boas",
                   AccessType = AccessType.Employee,
                   Id = Guid.NewGuid(),
                   Created_At = DateTime.UtcNow
               }
        );
    }
}
