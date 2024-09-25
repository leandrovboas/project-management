using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Core.Entities;
using ProjectManagement.Infra.Configurations;
using ProjectManagement.Infra.Persistence;
using ProjectManagement.Test.Builders;

namespace ProjectManagement.Test.Repository
{
    internal class UserRepositoryTest
    {

        [Test]
        public async Task ShouldReturnExpectedResult()
        {

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "ProjectManagement")
            .Options;


            using (var context = new ApplicationDbContext(options))
            {
                context.Users.Add( new UserBuilders().BuildObject());
                context.Users.Add( new UserBuilders().BuildObject());
                context.Users.Add( new UserBuilders().BuildObject());
                context.SaveChanges();
            }

            using (var context = new ApplicationDbContext(options))
            {
                UserRepository userRepository = new(context);
                List<User> result = await userRepository.GetAllUserAsync();

                result.Should().HaveCount(3);
            }
        }
    }
}
