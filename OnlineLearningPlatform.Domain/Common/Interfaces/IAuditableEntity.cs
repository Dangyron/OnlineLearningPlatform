namespace OnlineLearningPlatform.Domain.Common.Interfaces;

public interface IAuditableEntity<out TId> : IEntity<TId>
{
    DateTime CreatedAt { get; }
    DateTime? ModifiedAt { get; }
    DateTime? DeletedAt { get; }
}