namespace MyFluentValidation.Implementation.Rules
{
    internal class NotEmpty<T> : PropertyRuleBase<T, string>
    {
        protected override Predicate<string?> ValidationPredicate { get; } = property =>
            !string.IsNullOrEmpty(property);

        protected override bool AllowNullPropertyValue { get; } = true;

        protected override string ErrorMessage { get; } = "Value is null or empty";
    }
}
