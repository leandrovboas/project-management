using ProjectManagement.Core.Enums;

namespace ProjectManagement.Core.Entities;

internal class Project
{
    private readonly int MAX_WORKITEMS = 20;

    public Project(string name, List<WorkItems> workItems, Guid userId)
    {
        Name = name;
        WorkItems = workItems; 
        UserId = userId; 
    }

    public string Name { get; }
    public List<WorkItems> WorkItems { get; }
    public Guid UserId { get; }
    public bool IsDeleted { get; private set; } = true;

    public bool CanBeDeleted() => WorkItems.All(t => t.Status == WorkItemsStatus.Completed);

    public bool CanBeCreatedWorkItem() => WorkItems.Count < MAX_WORKITEMS;

    public bool ChangeIsDeleted(bool value) => this.IsDeleted = value;
}
