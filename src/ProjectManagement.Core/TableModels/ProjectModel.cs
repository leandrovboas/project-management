namespace ProjectManagement.Core.TableModels;

public record ProjectModel : TableModelsBase
{

    public required string Name { get; set; }
    public required Guid UserId { get; set; }
    public required bool IsDeleted { get;  set; } = false;
    public List<WorkItemsModel>? WorkItems { get; }

}
