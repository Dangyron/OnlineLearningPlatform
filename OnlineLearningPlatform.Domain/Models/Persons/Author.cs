using OnlineLearningPlatform.Domain.Common.CoreEntities;

namespace OnlineLearningPlatform.Domain.Models.Persons;

public class Author(
    string firstName,
    string lastName,
    string middleName,
    string suffix,
    string email,
    string phoneNumber,
    string description,
    string profilePictureUrl)
    : Person(firstName, lastName, middleName, suffix, email, phoneNumber, description, profilePictureUrl)
{
    public List<Guid> CreatedCourses { get; } = new();
}