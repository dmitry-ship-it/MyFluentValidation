namespace MyFluentValidation.Implementation.Rules
{
    internal class NotNull<T, TProperty> : PropertyRuleBase<T, TProperty>
        where TProperty : class
    {
        protected override Predicate<TProperty?> ValidationPredicate { get; } = property =>
            property is not null;

        protected override string ErrorMessage { get; } = "Value should not be null";

        protected override bool AllowNullPropertyValue { get; } = true;
    }
}
