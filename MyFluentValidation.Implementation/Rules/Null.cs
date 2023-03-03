namespace MyFluentValidation.Implementation.Rules
{
    internal class Null<T, TProperty> : PropertyRuleBase<T, TProperty>
        where TProperty : class
    {
        protected override Predicate<TProperty?> ValidationPredicate { get; } = property => property is null;

        protected override string ErrorMessage { get; } = "Value should be null";

        protected override bool AllowNullPropertyValue { get; } = true;
    }
}
