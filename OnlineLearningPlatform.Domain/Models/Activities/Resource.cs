using OnlineLearningPlatform.Domain.Common.CoreEntities;

namespace OnlineLearningPlatform.Domain.Models.Activities;

public class Resource(string title, string url, string resourceType, Guid uploaderId) : BaseEntity
{
    public string Title { get; set; } = title;
    public string Url { get; set; } = url;
    public string ResourceType { get; set; } = resourceType;
    public Guid UploaderId { get; set; } = uploaderId;
}