namespace OnlineLearningPlatform.Domain.Common.Interfaces;

public interface IAuditableEntity : IEntity
{
    DateTime CreatedAt { get; }
    DateTime? ModifiedAt { get; }
    DateTime? DeletedAt { get; }
}