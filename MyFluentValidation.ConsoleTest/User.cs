namespace MyFluentValidation.ConsoleTest
{
    internal class User
    {
        public string? Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; } = default!;
    }
}
