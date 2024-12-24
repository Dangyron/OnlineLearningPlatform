namespace OnlineLearningPlatform.Domain.Models.Activities;

public class Quiz(Guid moduleId, string title, string description, int order)
    : Activity(moduleId, title, description, order, Common.Constants.ActivityType.Quiz)
{
    public List<Guid> Questions = new();
}