namespace OnlineLearningPlatform.Application.Common.Security.Permissions;

public static partial class Permission
{
    public static class Course
    {
        public const string Create = "create:course";
        public const string Get = "get:course";
        public const string Update = "update:course";
        public const string Delete = "delete:course";
    }
}