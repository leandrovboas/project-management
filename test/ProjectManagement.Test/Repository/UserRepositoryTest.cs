using AutoMapper;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Application.AuteMapper;
using ProjectManagement.Core.TableModels;
using ProjectManagement.Infra.Configurations;
using ProjectManagement.Infra.Persistence;
using ProjectManagement.Test.Builders;

namespace ProjectManagement.Test.Repository
{
    internal class UserRepositoryTest
    {

        private Mapper _mapper;
        public UserRepositoryTest()
        {
            _mapper = new Mapper(
           new MapperConfiguration(cfg => cfg.AddProfile(new UserProfile())));
        }

        [Test]
        public async Task ShouldReturnExpectedResult()
        {

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "ProjectManagement")
            .Options;


            using (var context = new ApplicationDbContext(options))
            {
                context.Users.Add(_mapper.Map <UserModel> (new UserBuilders().BuildObject()));
                context.Users.Add(_mapper.Map <UserModel> (new UserBuilders().BuildObject()));
                context.Users.Add(_mapper.Map <UserModel> (new UserBuilders().BuildObject()));
                context.SaveChanges();
            }

            using (var context = new ApplicationDbContext(options))
            {
                UserRepository userRepository = new(context);
                List<UserModel> result = await userRepository.GetAllUserAsync();

                result.Should().HaveCount(3);
            }
        }
    }
}
