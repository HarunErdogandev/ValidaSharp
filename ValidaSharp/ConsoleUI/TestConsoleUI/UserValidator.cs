using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidaSharp;

namespace ConsoleUI.TestConsoleUI
{
    public static class UserValidator
    {
        public static Validator<User> GetValidator()
        {
            return new Validator<User>()
                .AddRule(u => !string.IsNullOrWhiteSpace(u.Username), "Username cannot be empty.")
                .AddRule(u => u.Age >= 18 && u.Age <= 99, "Age must be between 18 and 99.")
                .AddRule(u => !string.IsNullOrWhiteSpace(u.Email) && u.Email.Contains("@"), "Invalid email address.");
        }
    }
}
