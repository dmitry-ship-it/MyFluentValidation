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
    }
}
