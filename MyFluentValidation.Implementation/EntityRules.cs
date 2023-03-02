using MyFluentValidation.Abstractions;

namespace MyFluentValidation.Implementation
{
    public class EntityRules<T> : IEntityRules<T>
    {
        private readonly IList<IPropertyRuleSet<T>> rules = new List<IPropertyRuleSet<T>>();

        public void Add<TProperty>(IPropertyRuleSet<T, TProperty> set)
        {
            rules.Add(set);
        }

        public IValidationResult ValidateEverything(T entity)
        {
            var result = new ValidationResult();

            for (var i = 0; i < rules.Count; i++)
            {
                var current = rules[i].Validate(entity);

                if (!current.IsValid)
                {
                    for (var j = 0; j < current.Errors.Count; j++)
                    {
                        result.Errors.Add(current.Errors[j]);
                    }
                }
            }

            return result;
        }
    }
}
