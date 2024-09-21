using Microsoft.EntityFrameworkCore;
using ProjectManagement.Core.Entities;
using ProjectManagement.Core.Enums;

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
        modelBuilder.Entity<User>().HasData(
               new User() { Name = "Leandro Vilas Boas", AccessType = AccessType.Manager },
               new User() { Name = "Thais Vilas Boas", AccessType = AccessType.Manager },
               new User() { Name = "Mariana Vilas Boas", AccessType = AccessType.Manager }
        );
    }
}
