namespace ProjectManagement.Core.Entities;
public abstract class EntityBase
{
    public EntityBase()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; private set; }
    public DateTime Created_At { get;  set; }
    public DateTime Updated_At { get; set; }
}