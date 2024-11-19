using OnlineLearningPlatform.Domain.Common.CoreEntities;

namespace OnlineLearningPlatform.Domain.Models;

public class Course : AuditableEntity<Guid>
{
    public string Title { get; private set; }
    public string Description { get; private set; } 
    public string Category { get; private set; } 
    public TimeSpan Duration { get; private set; }

    public Guid TeacherId { get; private set; }
    public Teacher Teacher { get; private set; }
    
    private IList<Lesson> _lessons = new List<Lesson>();
    public IEnumerable<Lesson> Lessons => _lessons;

    public string ThumbnailUrl { get; private set; }

    protected Course() { }

    public Course(Guid id, string title, string description, string category, TimeSpan duration, 
        string thumbnailUrl, Guid teacherId, DateTime createdAt)
        : base(id, createdAt)
    {
        Title = title;
        Description = description;
        Category = category;
        Duration = duration;
        ThumbnailUrl = thumbnailUrl;
        TeacherId = teacherId;
    }

    public void AddLesson(Lesson lesson)
    {
        _lessons.Add(lesson);
    }
}