using MyFluentValidation.Abstractions;
using MyFluentValidation.Implementation.Exceptions;
using System.Linq.Expressions;

namespace MyFluentValidation.Implementation
{
    public abstract class AbstractValidator<T> : IValidator<T>
    {
        private readonly IEntityRules<T> set = new EntityRules<T>();

        public IValidationResult Validate(T entity)
        {
            return set.ValidateEverything(entity);
        }

        public void ValidateAndThrow(T entity)
        {
            var result = Validate(entity);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }

        protected IPropertyRuleSet<T, TProperty> RuleFor<TProperty>(Expression<Func<T, TProperty?>> selector)
        {
            if (selector.Body is not MemberExpression)
            {
                throw new ArgumentException("Provided expression is not MemberExpression", nameof(selector));
            }

            var propertyRuleSet = new PropertyRuleSet<T, TProperty>(selector);

            set.Add(propertyRuleSet);

            return propertyRuleSet;
        }
    }
}