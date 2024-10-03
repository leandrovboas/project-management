using ProjectManagement.Core.Enums;

namespace ProjectManagement.Core.TableModels;

public record WorkItemsModel : TableModelsBase
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public WorkItemsPriority Priority { get; set; }
    public WorkItemsStatus Status { get; set; }
    public Guid ProjectId { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid UpdatedBy { get; set; }
    public DateTime CreatedAt { get; }
    public DateTime UpdatedAt { get; set; }

    public required ProjectModel Project { get; set; }
}
