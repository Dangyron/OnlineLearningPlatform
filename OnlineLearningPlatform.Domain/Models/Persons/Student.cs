using OnlineLearningPlatform.Domain.Common.CoreEntities;

namespace OnlineLearningPlatform.Domain.Models.Persons;

public class Student(
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
    public List<Course> EnrolledCourses { get; set; } = new();
}