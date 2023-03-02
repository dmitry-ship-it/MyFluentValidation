using System.Text.Json;

namespace MyFluentValidation.ConsoleTest;

public static class Program
{
    static void Main()
    {
        var user = new User()
        {
            Name = "Jon Doe",
            Age = -33
        };

        var validator = new UserValidator();

        var result = validator.Validate(user);

        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
