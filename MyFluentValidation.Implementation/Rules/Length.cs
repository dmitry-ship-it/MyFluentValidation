namespace MyFluentValidation.Implementation.Rules
{
    internal class Length<T> : PropertyRuleBase<T, string>
    {
        protected override Predicate<string?> ValidationPredicate { get; }

        protected override bool AllowNullPropertyValue { get; }

        protected override string ErrorMessage { get; }

        public Length(int length)
        {
            ValidationPredicate = property => property?.Length == length;
            ErrorMessage = $"String length is not equals to {length}";
        }
    }

    internal class Length<T, TProperty> : PropertyRuleBase<T, TProperty>
        where TProperty : IEnumerable<object>
    {
        protected override Predicate<TProperty?> ValidationPredicate { get; }

        protected override bool AllowNullPropertyValue { get; }

        protected override string ErrorMessage { get; }

        public Length(int length)
        {
            ValidationPredicate = property => property?.Count() == length;
            ErrorMessage = $"Collection length is not equals to {length}";
        }
    }
}
