﻿using AutoMapper;
using FluentAssertions;
using Moq;
using ProjectManagement.Application.AuteMapper;
using ProjectManagement.Application.DTOs;
using ProjectManagement.Application.UseCases.User;
using ProjectManagement.Core.Entities;
using ProjectManagement.Core.Repositories;
using ProjectManagement.Core.TableModels;
using ProjectManagement.Test.Builders;

namespace ProjectManagement.Test.Repository
{
    internal class UserUseCaseTest : BaseTest
    {
        private Mapper _mapper;

        [SetUp]
        public void SetUp()
        {

            _mapper = new Mapper(
                new MapperConfiguration(cfg => cfg.AddProfile(new UserProfile())));

        }


        [Test]
        public async Task ShouldReturnExpectedResultAmount()
        {

            var users = new List<User>
            {
                new UserBuilders().BuildObject(),
                new UserBuilders().BuildObject()
            };
            var userModel = _mapper.Map<List<UserModel>>(users);

            var userReposiitory = new Mock<IUserRepository>();
            userReposiitory
                .Setup(x => x.GetAllUserAsync())
                .ReturnsAsync(userModel);


            var getUserUseCase = new GetUserUseCase(userReposiitory.Object, _mapper);

            var result = await getUserUseCase.ExecuteAsync();
            result.Should().HaveCount(2);
        }

        [Test]
        public async Task ShouldReturnExpectedResult()
        {
            var user = new UserBuilders().BuildObject();
            var users = new List<User>
            {
                user
            };

            var userModel = _mapper.Map<List<UserModel>>(users);

            var userReposiitory = new Mock<IUserRepository>();
            userReposiitory
                .Setup(x => x.GetAllUserAsync())
                .ReturnsAsync(userModel);

            var expected = _mapper.Map<UserResponse>(user);

            var getUserUseCase = new GetUserUseCase(userReposiitory.Object, _mapper);

            var result = await getUserUseCase.ExecuteAsync();
            result.FirstOrDefault().Should().BeEquivalentTo(expected);
        }

        [Test]
        public async Task ShouldReturnExpectedToRepositoryResultEmpty()
        {
            var userReposiitory = new Mock<IUserRepository>();
            userReposiitory
                .Setup(x => x.GetAllUserAsync())
                .ReturnsAsync([]);

            var getUserUseCase = new GetUserUseCase(userReposiitory.Object, _mapper);

            var result = await getUserUseCase.ExecuteAsync();
            result.Should().HaveCount(0);
        }
    }
}
