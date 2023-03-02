using MyFluentValidation.Abstractions;

namespace MyFluentValidation.Implementation.Rules
{
    public class Range<T, TProperty> : IPropertyRule<T, TProperty>
        where TProperty : IComparable<TProperty>
    {
        private const string ErrorMessage = "Value should be null";

        private readonly TProperty from;
        private readonly TProperty to;

        public Range(TProperty from, TProperty toInclusive)
        {
            this.from = from;
            to = toInclusive;
        }

        public IPropertyValidationResult Validate(T entity, Func<T, TProperty> accessor)
        {
            var value = accessor(entity);
            var isValid = value.CompareTo(from) >= 1
                && to.CompareTo(value) <= 0;

            return new PropertyValidationResult
            {
                IsValid = isValid,
                Message = !isValid ? ErrorMessage : null
            };
        }
    }
}
