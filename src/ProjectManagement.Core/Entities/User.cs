using ProjectManagement.Core.Enums;

namespace ProjectManagement.Core.Entities;

public class User : EntityBase
{
    public required string Name { get; set; }
    public required AccessType AccessType { get; set; }   
}
