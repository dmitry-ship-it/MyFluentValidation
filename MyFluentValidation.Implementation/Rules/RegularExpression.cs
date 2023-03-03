using System.Text.RegularExpressions;

namespace MyFluentValidation.Implementation.Rules
{
    internal class RegularExpression<T> : PropertyRuleBase<T, string>
    {
        protected override Predicate<string?> ValidationPredicate { get; }

        protected override bool AllowNullPropertyValue { get; }

        protected override string ErrorMessage { get; } = "Value does not match";

        public RegularExpression(string pattern)
        {
            ValidationPredicate = property => Regex.IsMatch(property!, pattern);
        }
    }
}
