using MyFluentValidation.Abstractions;

namespace MyFluentValidation.Implementation.Rules
{
    public class NotNull<T, TProperty> : IPropertyRule<T, TProperty>
        where TProperty : class
    {
        private const string ErrorMessage = "Value should not be null";

        public IPropertyValidationResult Validate(T entity, Func<T, TProperty> accessor)
        {
            var isValid = accessor(entity) is not null;

            return new PropertyValidationResult
            {
                IsValid = isValid,
                Message = !isValid ? ErrorMessage : null
            };
        }
    }
}
