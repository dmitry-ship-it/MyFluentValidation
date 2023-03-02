using MyFluentValidation.Abstractions;

namespace MyFluentValidation.Implementation
{
    [Serializable]
    public class ValidationFailure : IValidationFailure
    {
        public string PropertyName { get; set; }

        public string ErrorMessage { get; set; }

        public object? AttemptedValue { get; set; }

        public ValidationFailure(string propertyName, string errorMessage)
            : this(propertyName, errorMessage, null)
        {
        }

        public ValidationFailure(string propertyName, string errorMessage, object? attemptedValue)
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