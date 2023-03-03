namespace MyFluentValidation.Abstractions
{
    public interface IPropertyValidationResult
    {
        bool IsValid { get; init; }

        string? Message { get; init; }

        string? PropertyName { get; init; }

        object? AttemptedValue { get; init; }
    }
}
