using ProjectManagement.Core.Enums;

namespace ProjectManagement.Core.Entities;

public class Users
{
    public required string Name { get; set; }
    public required AccessType AccessType { get; set; }   
}
