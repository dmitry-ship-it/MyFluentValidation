using MyFluentValidation.Abstractions;
using System.Linq.Expressions;

namespace MyFluentValidation.Implementation
{
    public class PropertyRuleSet<T, TProperty> : IPropertyRuleSet<T, TProperty>
    {
        private readonly Expression<Func<T, TProperty?>> accessor;
        private readonly List<IPropertyRule<T, TProperty>> propertyRules = new();

        public PropertyRuleSet(Expression<Func<T, TProperty?>> accessor)
        {
            this.accessor = accessor;
        }

        public void Add(IPropertyRule<T, TProperty> propertyRule)
        {
            propertyRules.Add(propertyRule);
        }

        public IValidationResult Validate(T entity)
        {
            var result = new ValidationResult();

            foreach (var rule in propertyRules)
            {
                var current = rule.Validate(entity, accessor);

                if (!current.IsValid)
                {
                    result.Errors.Add(new ValidationFailure(
                        current.PropertyName!,
                        current.Message!,
                        current.AttemptedValue!
                    ));
                }
            }

            return result;
        }
    }
}
