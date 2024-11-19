using OnlineLearningPlatform.Domain.Common.CoreEntities;

namespace OnlineLearningPlatform.Domain.Models;

public class Teacher : Person
{
    private readonly IList<Course> _taughtCourses = new List<Course>();
    public IEnumerable<Course> TaughtCourses => _taughtCourses;
    
    public Teacher(string firstName, string lastName, string middleName, string suffix, string email, string phoneNumber, 
        string description, string profilePictureUrl)
        : base(firstName, lastName, middleName, suffix, email, phoneNumber, description, profilePictureUrl)
    {
    }
    
    protected Teacher() { }
}