namespace MyFluentValidation.Abstractions
{
    public interface IValidationFailure
    {
        string PropertyName { get; set; }

        string ErrorMessage { get; set; }

        object? AttemptedValue { get; set; }
    }
}
