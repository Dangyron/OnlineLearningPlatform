namespace OnlineLearningPlatform.Domain.Common.CoreEntities;

public abstract class Person(
    string firstName,
    string lastName,
    string? middleName,
    string? suffix,
    string email,
    string? phoneNumber,
    string? description,
    string? profilePictureUrl)
    : BaseEntity
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public string? MiddleName { get; set; } = middleName;
    public string? Suffix { get; set; } = suffix;

    public string Email { get; set; } = email;
    public string? PhoneNumber { get; set; } = phoneNumber;

    public string? Description { get; set; } = description;
    public string? ProfilePictureUrl { get; set; } = profilePictureUrl;
}