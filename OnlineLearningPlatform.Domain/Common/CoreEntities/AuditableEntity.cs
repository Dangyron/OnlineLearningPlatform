using OnlineLearningPlatform.Domain.Common.Interfaces;

namespace OnlineLearningPlatform.Domain.Common.CoreEntities;

public abstract class AuditableEntity<TId> : IAuditableEntity<TId>
{
    public TId Id { get; protected set; }
    public DateTime CreatedAt { get; protected set; }
    public DateTime? ModifiedAt { get; protected set; }
    public DateTime? DeletedAt { get; protected set; }

    protected AuditableEntity(TId id, DateTime createdAt)
    {
        Id = id;
        CreatedAt = createdAt;
    }

    protected AuditableEntity() { }
}