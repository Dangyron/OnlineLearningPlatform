namespace OnlineLearningPlatform.Domain.Common.Interfaces;

public interface IAuditableEntity<out TId> : IEntity<TId>
{
    DateTime CreatedOn { get; }
    DateTime ModifiedOn { get; }
    DateTime? DeletedOn { get; }
}