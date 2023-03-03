using MyFluentValidation.Abstractions;
using System.Linq.Expressions;

namespace MyFluentValidation.Implementation.Rules
{
    internal abstract class PropertyRuleBase<T, TProperty> : IPropertyRule<T, TProperty>
    {
        protected abstract Predicate<TProperty?> ValidationPredicate { get; }
        protected abstract bool AllowNullPropertyValue { get; }
        protected abstract string ErrorMessage { get; }

        public virtual IPropertyValidationResult Validate(T entity, Expression<Func<T, TProperty?>> accessor)
        {
            var memberExpression = (MemberExpression)accessor.Body;
            var lambda = accessor.Compile();
            var attemptedValue = lambda(entity);

            bool isValid;
            if (AllowNullPropertyValue)
            {
                isValid = ValidationPredicate(attemptedValue);
            }
            else if (attemptedValue is not null)
            {
                isValid = ValidationPredicate(attemptedValue);
            }
            else
            {
                isValid = false;
            }

            return new PropertyValidationResult
            {
                IsValid = isValid,
                Message = !isValid ? ErrorMessage : null,
                PropertyName = memberExpression.Member.Name,
                AttemptedValue = attemptedValue
            };
        }
    }
}
