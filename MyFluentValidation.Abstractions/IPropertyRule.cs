namespace MyFluentValidation.Abstractions
{
    public interface IPropertyRule<T, TProperty>
    {
        IPropertyValidationResult Validate(T entity, Func<T, TProperty> accessor);
    }
}
