namespace Optional.Attributes;

internal abstract class ValidationAttribute : Attribute
{
    public abstract bool IsValid(object? propertyValue);
    public string? ErrorMessage { get; set; }
}