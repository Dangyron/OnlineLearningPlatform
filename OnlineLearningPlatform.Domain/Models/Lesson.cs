using OnlineLearningPlatform.Domain.Common.CoreEntities;

namespace OnlineLearningPlatform.Domain.Models;

public class Lesson : AuditableEntity<Guid>
{
    public string Title { get; private set; }
    public string Content { get; private set; }
    public string VideoUrl { get; private set; }

    public Guid CourseId { get; private set; }
    public Course Course { get; private set; }

    protected Lesson() { }

    public Lesson(Guid id, string title, string content,
        string videoUrl, Guid courseId, DateTime createdAt)
        : base(id, createdAt)
    {
        Title = title;
        Content = content;
        VideoUrl = videoUrl;
        CourseId = courseId;
    }
}