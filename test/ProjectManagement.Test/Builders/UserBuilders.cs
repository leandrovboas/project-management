using ProjectManagement.Core.Entities;
using ProjectManagement.Core.Enums;

namespace ProjectManagement.Test.Builders
{
    internal class UserBuilders : BaseBuilder<User>
    {
        public override User BuildObject() => CreateWorkItem();

        private User CreateWorkItem() =>
             new User
             {
                 Name = Faker.Person.FullName,
                 AccessType = AccessType.Manager
             };

    }
}

