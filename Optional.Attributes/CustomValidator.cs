using System.Reflection;

namespace Optional.Attributes;

internal class ValidationService
{
    public ValidationResult Validate<T>(T objectToValidate)
    {
        var validationResult = new ValidationResult();

        foreach (var propertyInfo in typeof(T).GetProperties())
        {
            var validationAttributes = propertyInfo.GetCustomAttributes().OfType<ValidationAttribute>();

            var propertyValue = propertyInfo.GetValue(objectToValidate);

            foreach (var validationAttribute in validationAttributes)
                if (!validationAttribute.IsValid(propertyValue))
                    validationResult.AddError(validationAttribute.ErrorMessage);
        }

        return validationResult;
    }
}