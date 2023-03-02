using MyFluentValidation.Abstractions;

namespace MyFluentValidation.Implementation
{
    [Serializable]
    public class ValidationResult : IValidationResult
    {
        private IList<IValidationFailure> validationFailures = new List<IValidationFailure>();

        public IList<IValidationFailure> Errors
        {
            get => validationFailures;
            set
            {
                validationFailures = value is null
                    ? new List<IValidationFailure>()
                    : value.Where(item => item is not null).ToList();
            }
        }

        public bool IsValid => Errors.Count == 0;

        public ValidationResult()
        {
        }

        public ValidationResult(IEnumerable<IValidationFailure> validationFailures)
        {
            Errors = validationFailures.ToList();
        }
    }
}
