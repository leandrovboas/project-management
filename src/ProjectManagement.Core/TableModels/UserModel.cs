using ProjectManagement.Core.Enums;

namespace ProjectManagement.Core.TableModels;

public record UserModel : TableModelsBase
{
    public required string Name { get; set; }
    public required AccessType AccessType { get; set; }   
}
