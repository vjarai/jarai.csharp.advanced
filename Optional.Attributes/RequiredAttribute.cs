namespace Optional.Attributes;

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
sealed class RequiredAttribute : ValidationAttribute
{

    public override bool IsValid(object? propertyValue)
    {
        return propertyValue is not null;
    }
}