namespace MyFluentValidation.Abstractions
{
    public interface IValidator<in T>
    {
        IValidationResult Validate(T entity);

        void ValidateAndThrow(T entity);
    }
}
