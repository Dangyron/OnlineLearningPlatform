namespace OnlineLearningPlatform.Domain.Models;

public class Module(Guid courseId, string title, int order)
{
    public Guid CourseId { get; set; } = courseId;
    public string Title { get; set; } = title;
    public int Order { get; set; } = order;
    public List<Guid> Activities { get; set; } = new();
}