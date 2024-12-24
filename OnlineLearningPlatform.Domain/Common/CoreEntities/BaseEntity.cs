using OnlineLearningPlatform.Domain.Common.Interfaces;

namespace OnlineLearningPlatform.Domain.Common.CoreEntities;

public abstract class BaseEntity : IAuditableEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? ModifiedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}