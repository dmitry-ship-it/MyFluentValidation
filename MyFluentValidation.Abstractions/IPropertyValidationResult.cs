namespace MyFluentValidation.Abstractions
{
    public interface IPropertyValidationResult
    {
        bool IsValid { get; }

        string? Message { get; }
    }
}
