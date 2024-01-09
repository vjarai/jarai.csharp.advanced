namespace Optional.Attributes;

internal class ValidationResult
{
    private List<string?> _errors = new List<string?>();

    public override string ToString()
    {
        return string.Join('\n', _errors);
    }

    public bool HasErrors()
    {
        return _errors.Any();
    }

    public void AddError(string? errorMessage)
    {
        _errors.Add(errorMessage);
    }
}