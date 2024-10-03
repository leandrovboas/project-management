namespace ProjectManagement.Core.TableModels;

public abstract record TableModelsBase
{
    public Guid Id { get; set; }
    public DateTime Created_At { get; set; }
    public DateTime Updated_At { get; set; }
}


