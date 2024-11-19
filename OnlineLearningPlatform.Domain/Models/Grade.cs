using OnlineLearningPlatform.Domain.Common.CoreEntities;

namespace OnlineLearningPlatform.Domain.Models;

public class Grade : AuditableEntity<Guid>
{
    public Grade(Guid submissionId, float value) 
        : base(Guid.NewGuid(), DateTime.UtcNow)
    {
        SubmissionId = submissionId;
        Value = value;
    }

    public Guid SubmissionId { get; set; }
    public float Value { get; set; }
    
    protected Grade() { }
}