using MyFluentValidation.Abstractions;
using MyFluentValidation.Implementation.Rules;

namespace MyFluentValidation.Implementation.Extensions
{
    public static class PropertyRuleSetExtension
    {
        public static IPropertyRuleSet<T, TProperty> Range<T, TProperty>(
            this IPropertyRuleSet<T, TProperty> set, TProperty from, TProperty toInclusive)
            where TProperty : IComparable<TProperty>
        {
            set.Add(new Range<T, TProperty>(from, toInclusive));

            return set;
        }

        public static IPropertyRuleSet<T, TProperty> Null<T, TProperty>(this IPropertyRuleSet<T, TProperty> set)
            where TProperty : class
        {
            set.Add(new Null<T, TProperty>());

            return set;
        }

        public static IPropertyRuleSet<T, TProperty> NotNull<T, TProperty>(this IPropertyRuleSet<T, TProperty> set)
            where TProperty : class
        {
            set.Add(new NotNull<T, TProperty>());

            return set;
        }

        public static IPropertyRuleSet<T, string> Empty<T>(this IPropertyRuleSet<T, string> set)
        {
            set.Add(new Empty<T>());

            return set;
        }

        public static IPropertyRuleSet<T, string> NotEmpty<T>(this IPropertyRuleSet<T, string> set)
        {
            set.Add(new NotEmpty<T>());

            return set;
        }

        public static IPropertyRuleSet<T, TProperty> UsingPredicate<T, TProperty>(
            this IPropertyRuleSet<T, TProperty> set,
            Predicate<TProperty?> predicate)
        {
            set.Add(new UsingPredicate<T, TProperty>(predicate));

            return set;
        }

        public static IPropertyRuleSet<T, IEnumerable<object>> Length<T>(
            this IPropertyRuleSet<T, IEnumerable<object>> set,
            int length)
        {
            set.Add(new Length<T, IEnumerable<object>>(length));

            return set;
        }

        public static IPropertyRuleSet<T, string> Length<T>(
            this IPropertyRuleSet<T, string> set,
            int length)
        {
            set.Add(new Length<T>(length));

            return set;
        }

        public static IPropertyRuleSet<T, string> RegularExpression<T>(
            this IPropertyRuleSet<T, string> set,
            string pattern)
        {
            set.Add(new RegularExpression<T>(pattern));

            return set;
        }

        public static IPropertyRuleSet<T, string> Email<T>(this IPropertyRuleSet<T, string> set)
        {
            set.Add(new Email<T>());

            return set;
        }
    }
}
