using OnlineLearningPlatform.Domain.Common.CoreEntities;

namespace OnlineLearningPlatform.Domain.Models.Activities;

public abstract class Activity(Guid moduleId, string title, string description, int order, string activityType)
    : BaseEntity
{
    public Guid ModuleId { get; set; } = moduleId;
    public string Title { get; set; } = title;
    public string Description { get; set; } = description;
    public int Order { get; set; } = order;
    public string ActivityType { get; set; } = activityType;
}