namespace MyFluentValidation.Abstractions
{
    public interface IPropertyRuleSet<in T>
    {
        IValidationResult Validate(T entity);
    }

    public interface IPropertyRuleSet<T, TProperty> : IPropertyRuleSet<T>
    {
        void Add(IPropertyRule<T, TProperty> propertyRule);
    }
}
