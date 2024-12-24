using OnlineLearningPlatform.Domain.Common.CoreEntities;

namespace OnlineLearningPlatform.Domain.Models;

public class Enrollment(Guid courseId, Guid studentId, string status) : BaseEntity
{
    public Guid CourseId { get; set; } = courseId;
    public Guid StudentId { get; set; } = studentId;
    public string Status { get; set; } = status;
}