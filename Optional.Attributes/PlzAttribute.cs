namespace Optional.Attributes;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
sealed class PlzAttribute : ValidationAttribute
{

    public override bool IsValid(object? fieldToValidate)
    {
        if (fieldToValidate == null)
            return true;

        string plz = (string)fieldToValidate;

        return  plz.Length == 5;

    }
}