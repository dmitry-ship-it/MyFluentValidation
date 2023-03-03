namespace MyFluentValidation.Implementation.Rules
{
    internal class UsingPredicate<T, TProperty> : PropertyRuleBase<T, TProperty>
    {
        protected override Predicate<TProperty?> ValidationPredicate { get; }

        protected override bool AllowNullPropertyValue { get; } = true;

        protected override string ErrorMessage { get; }

        public UsingPredicate(Predicate<TProperty?> predicate)
        {
            ValidationPredicate = predicate;
            ErrorMessage = $"Value did not pass validation by predicate {predicate}";
        }
    }
}
