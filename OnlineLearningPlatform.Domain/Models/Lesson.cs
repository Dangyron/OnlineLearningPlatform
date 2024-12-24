using OnlineLearningPlatform.Domain.Common.CoreEntities;

namespace OnlineLearningPlatform.Domain.Models;

public class Lesson(
    Guid id,
    string title,
    string content,
    string videoUrl,
    Guid courseId)
{
    public string Title { get; private set; } = title;
    public string Content { get; private set; } = content;
    public string VideoUrl { get; private set; } = videoUrl;
    public Guid CourseId { get; private set; } = courseId;
}