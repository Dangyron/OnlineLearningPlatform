namespace OnlineLearningPlatform.Domain.Common.Interfaces;

public interface IEntity<out TId>
{
    TId Id { get; }
}