namespace MyFluentValidation.Abstractions
{
    public interface IValidationFailure
    {
        string PropertyName { get; init; }

        string ErrorMessage { get; init; }

        object AttemptedValue { get; init; }
    }
}
