using OnlineLearningPlatform.Domain.Common.CoreEntities;

namespace OnlineLearningPlatform.Domain.Models;

public class Course(
    string title,
    string description,
    string category,
    string level,
    DateTime startDate,
    DateTime endDate,
    Guid authorId)
    : BaseEntity
{
    public string Title { get; set; } = title;
    public string Description { get; set; } = description;
    public string Category { get; set; } = category;
    public string Level { get; set; } = level;
    public DateTime StartDate { get; set; } = startDate;
    public DateTime EndDate { get; set; } = endDate;
    public Guid AuthorId { get; set; } = authorId;
    public List<Guid> Teachers { get; set; } = new();
    public List<Guid> Students { get; set; } = new();
}