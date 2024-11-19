using OnlineLearningPlatform.Domain.Common.CoreEntities;

namespace OnlineLearningPlatform.Domain.Models;

public class Author : Person
{
    private readonly IList<Course> _authoredCourses = new List<Course>();
    public IEnumerable<Course> AuthorCourses => _authoredCourses;
    
    public Author(string firstName, string lastName, string middleName, string suffix, string email, string phoneNumber, 
        string description, string profilePictureUrl)
        : base(firstName, lastName, middleName, suffix, email, phoneNumber, description, profilePictureUrl)
    {
    }
    
    protected Author() { }
}
