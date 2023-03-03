using MyFluentValidation.Implementation;
using MyFluentValidation.Implementation.Extensions;

namespace MyFluentValidation.ConsoleTest
{
    internal class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(prop => prop.Name).NotNull().NotEmpty().Length(7);

            RuleFor(prop => prop.Age).Range(0, 100);

            RuleFor(prop => prop.Email).NotNull().NotEmpty().Email();
        }
    }
}
