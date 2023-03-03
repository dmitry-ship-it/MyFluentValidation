using System.Linq.Expressions;

namespace MyFluentValidation.Abstractions
{
    public interface IPropertyRule<T, TProperty>
    {
        IPropertyValidationResult Validate(T entity, Expression<Func<T, TProperty?>> accessor);
    }
}
