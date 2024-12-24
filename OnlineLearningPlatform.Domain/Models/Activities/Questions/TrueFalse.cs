namespace OnlineLearningPlatform.Domain.Models.Activities.Questions;

public class TrueFalse(Guid quizId, string text, string type, double points, int order)
    : Question(quizId, text, type, points, order)
{
    public bool IsCorrect { get; set; }
}