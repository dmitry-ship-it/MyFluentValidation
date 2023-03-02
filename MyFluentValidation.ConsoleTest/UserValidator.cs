using MyFluentValidation.Implementation;
using MyFluentValidation.Implementation.Extensions;

namespace MyFluentValidation.ConsoleTest
{
    internal class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            // TODO: Fix warning by adding ref types nullability signs and null checks
            RuleFor(prop => prop.Name).NotNull();

            RuleFor(prop => prop.Age).Range(0, 100);
        }
    }
}
