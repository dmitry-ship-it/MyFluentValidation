using MyFluentValidation.Abstractions;

namespace MyFluentValidation.Implementation
{
    [Serializable]
    public class ValidationFailure : IValidationFailure
    {
        public string PropertyName { get; init; }

        public string ErrorMessage { get; init; }

        public object AttemptedValue { get; init; }

        public ValidationFailure(string propertyName, string errorMessage, object attemptedValue)
        {
            PropertyName = propertyName;

            ErrorMessage = errorMessage;

            AttemptedValue = attemptedValue;
        }

        public override string ToString()
        {
            return ErrorMessage;
        }
    }
}