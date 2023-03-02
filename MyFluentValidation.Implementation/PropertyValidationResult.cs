using MyFluentValidation.Abstractions;

namespace MyFluentValidation.Implementation
{
    public class PropertyValidationResult : IPropertyValidationResult
    {
        public bool IsValid { get; set; }

        public string? Message { get; set; }
    }
}
