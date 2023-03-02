using MyFluentValidation.Abstractions;

namespace MyFluentValidation.Implementation.Rules
{
    public class Null<T, TProperty> : IPropertyRule<T, TProperty>
        where TProperty : class
    {
        private const string ErrorMessage = "Value should be null";

        public IPropertyValidationResult Validate(T entity, Func<T, TProperty> accessor)
        {
            var isValid = accessor(entity) is null;

            return new PropertyValidationResult
            {
                IsValid = isValid,
                Message = !isValid ? ErrorMessage : null
            };
        }
    }
}
