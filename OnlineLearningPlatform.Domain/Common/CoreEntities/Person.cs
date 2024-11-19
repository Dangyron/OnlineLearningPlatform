namespace OnlineLearningPlatform.Domain.Common.CoreEntities;

public class Person : AuditableEntity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? Suffix { get; set; }

    public string Email { get; set; }
    public string? PhoneNumber { get; set; }

    public string? Description { get; set; }
    public string? ProfilePictureUrl { get; set; }

    protected Person(string firstName, string lastName, string? middleName, string? suffix, string email, string? phoneNumber,
        string? description, string? profilePictureUrl)
        : base(Guid.NewGuid(), DateTime.UtcNow)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        Suffix = suffix;
        Email = email;
        PhoneNumber = phoneNumber;
        Description = description;
        ProfilePictureUrl = profilePictureUrl;
    }
    
    protected Person()
    {
    }
}