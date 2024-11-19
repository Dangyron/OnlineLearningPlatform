using Microsoft.AspNetCore.Identity;
using OnlineLearningPlatform.Domain.Common.Interfaces;

namespace OnlineLearningPlatform.Domain.Common.CoreEntities;

public class ApplicationUser : IdentityUser<Guid>, IAuditableEntity<Guid>
{
    public ApplicationUser()
    {
        CreatedAt = DateTime.UtcNow;
    }
    
    public DateTime CreatedAt { get; }
    public DateTime? ModifiedAt { get; private set; }
    public DateTime? DeletedAt { get; private set; }
}