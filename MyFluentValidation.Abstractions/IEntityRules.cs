namespace MyFluentValidation.Abstractions
{
    public interface IEntityRules<T>
    {
        void Add<TProperty>(IPropertyRuleSet<T, TProperty> set);

        IValidationResult ValidateEverything(T entity);
    }
}
