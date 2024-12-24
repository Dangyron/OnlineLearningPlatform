namespace OnlineLearningPlatform.Domain.Models.Activities;

public class Video(Guid moduleId, string title, string description, int order, string activityType, string videoUrl)
    : Activity(moduleId, title, description, order, activityType)
{
    public string VideoUrl { get; set; } = videoUrl;
}