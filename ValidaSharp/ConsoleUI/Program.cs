using ConsoleUI.TestConsoleUI;
using ValidaSharp;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User
            {
                Username = "Harun",
                Age = 18,
                Email = "Harun41gmail.com"
            };

            var validator = UserValidator.GetValidator();

            try
            {
                validator.ValidateAndThrow(user);
                Console.WriteLine("Validation successful!");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine("Validation failed. Errors:");
                foreach (var error in ex.Errors)
                {
                    Console.WriteLine("- " + error);
                }
            }
        }
    }
}