namespace OnlineLearningPlatform.Domain.Models.Activities.Questions;

public class Matching(Guid quizId, string text, string type, double points, int order)
    : Question(quizId, text, type, points, order)
{
    public List<string> LeftItems { get; set; } = new();
    public List<string> RightItems { get; set; } = new();
    public Dictionary<int, int> CorrectMatches { get; set; } = new();
}