using System.Text.Json;

namespace MyFluentValidation.ConsoleTest;

public static class Program
{
    static void Main()
    {
        var user = new User()
        {
            Name = null,
            Age = 22,
            Email = "jon.doe@mail.com"
        };

        var validator = new UserValidator();

        var result = validator.Validate(user);

        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
