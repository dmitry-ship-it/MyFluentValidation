namespace MyFluentValidation.Implementation.Rules
{
    internal class Empty<T> : PropertyRuleBase<T, string>
    {
        protected override Predicate<string?> ValidationPredicate { get; } = property =>
            string.IsNullOrEmpty(property);

        protected override bool AllowNullPropertyValue { get; } = true;

        protected override string ErrorMessage { get; } = "Value is not empty";
    }
}
