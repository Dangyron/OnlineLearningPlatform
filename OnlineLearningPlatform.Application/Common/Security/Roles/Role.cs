using Ardalis.SmartEnum;

namespace OnlineLearningPlatform.Application.Common.Security.Roles;

public abstract class Role : SmartEnum<Role>
{
    public static readonly Role Admin = new AdminRole();
    public static readonly Role Author = new AuthorRole();
    public static readonly Role Teacher = new TeacherRole();
    public static readonly Role Student = new StudentRole();

    public abstract IEnumerable<string> Permissions { get; }
    
    private Role(string name, int value) : base(name, value)
    {
    }

    private class AdminRole() : Role("admin", 0)
    {
        public override IEnumerable<string> Permissions => new List<string>();
    }
    
    private class AuthorRole() : Role("author", 1)
    {
        public override IEnumerable<string> Permissions => new List<string>();
    }
    
    private class TeacherRole() : Role("teacher", 2)
    {
        public override IEnumerable<string> Permissions => new List<string>();
    }
    
    private class StudentRole() : Role("student", 3)
    {
        public override IEnumerable<string> Permissions => new List<string>();
    }
}