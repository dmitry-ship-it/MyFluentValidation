using MyFluentValidation.Abstractions;

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
                // TODO: CREATE ValidationException
                throw new Exception();
            }
        }

        protected IPropertyRuleSet<T, TProperty> RuleFor<TProperty>(Func<T, TProperty> selector)
        {
            var propertyRuleSet = new PropertyRuleSet<T, TProperty>(selector);

            set.Add(propertyRuleSet);

            return propertyRuleSet;
        }
    }
}