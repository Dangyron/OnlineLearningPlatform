namespace OnlineLearningPlatform.Domain.Models.Activities.Questions;

public class MultipleChoice(Guid quizId, string text, string type, double points, int order) : Question(quizId, text, type, points, order)
{
    public List<string> Options { get; set; } = new(); 
    public List<int> CorrectOptionIndices { get; set; } = new();
}