using MyFluentValidation.Abstractions;

namespace MyFluentValidation.Implementation
{
    public class PropertyValidationResult : IPropertyValidationResult
    {
        public bool IsValid { get; init; }

        public string? Message { get; init; }

        public string? PropertyName { get; init; }

        public object? AttemptedValue { get; init; }
    }
}
