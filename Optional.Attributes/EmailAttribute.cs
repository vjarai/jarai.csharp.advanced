
namespace Optional.Attributes;

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
sealed class EmailAttribute : ValidationAttribute
{

    public override bool IsValid(object? propertyValue)
    {
        var email = propertyValue as string;

        return email is null || email.Contains("@");
    }
}