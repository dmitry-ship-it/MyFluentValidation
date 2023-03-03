namespace MyFluentValidation.Implementation.Rules
{
    internal class Range<T, TProperty> : PropertyRuleBase<T, TProperty>
        where TProperty : IComparable<TProperty>
    {
        protected override string ErrorMessage { get; }

        protected override Predicate<TProperty?> ValidationPredicate { get; }

        protected override bool AllowNullPropertyValue { get; }

        public Range(TProperty from, TProperty toInclusive)
        {
            ErrorMessage = $"Value is less than {from} or greater than {toInclusive}";
            ValidationPredicate = property =>
                property?.CompareTo(from) >= 0 && toInclusive.CompareTo(property) >= 0;
        }
    }
}
