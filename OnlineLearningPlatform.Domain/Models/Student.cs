using OnlineLearningPlatform.Domain.Common.CoreEntities;

namespace OnlineLearningPlatform.Domain.Models;

public class Student : Person
{
    private readonly IList<Course> _enrolledCourses = new List<Course>();
    public IEnumerable<Course> EnrolledCourses => _enrolledCourses;
    
    public Student(string firstName, string lastName, string middleName, string suffix, string email, string phoneNumber, 
        string description, string profilePictureUrl)
        : base(firstName, lastName, middleName, suffix, email, phoneNumber, description, profilePictureUrl)
    {
    }
    
    protected Student() { }
}