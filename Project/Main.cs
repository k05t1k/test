using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Project
{
    public class PasswordValidator
    {
        public int EvaluatePasswordStrength(string pass)
        {
            if (string.IsNullOrEmpty(pass))
                return 0;

            int score = 0;

            if (pass.Any(char.IsDigit))
                score++;

            if (pass.Any(char.IsLower))
                score++;

            if (pass.Any(char.IsUpper))
                score++;

            if (Regex.IsMatch(pass, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"))
                score++;

            if (pass.Length > 10)
                score++;

            return score;
        }

        static void Main()
        {
            PasswordValidator validator = new PasswordValidator();
            Console.WriteLine(validator.EvaluatePasswordStrength("ExamplePassword1!"));
        }
    }
}
