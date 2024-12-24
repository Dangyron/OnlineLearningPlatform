using OnlineLearningPlatform.Domain.Common.CoreEntities;

namespace OnlineLearningPlatform.Domain.Models.Activities.Questions;

public abstract class Question(Guid quizId, string text, string type, double points, int order) : BaseEntity
{
    public Guid QuizId { get; set; } = quizId;
    public string Text { get; set; } = text;
    public string Type { get; set; } = type;
    public double Points { get; set; } = points;
    public int Order { get; set; } = order;
}