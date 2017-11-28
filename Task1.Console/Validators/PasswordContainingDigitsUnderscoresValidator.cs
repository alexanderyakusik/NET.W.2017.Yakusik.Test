using System;
using System.Linq;
using Task1.Solution.PasswordValidators;

namespace Task1.Console.Validators
{
    public class PasswordContainingDigitsUnderscoresValidator : IPasswordValidator
    {
        public Tuple<bool, string> Validate(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException($"{nameof(password)} cannot be null.");
            }

            if (!password.Any(char.IsDigit))
            {
                return Tuple.Create(false, $"{password} must contain digits.");
            }

            if (password.All(chr => chr != '_'))
            {
                return Tuple.Create(false, $"{password} must contain underscores.");
            }

            return Tuple.Create(true, $"{password} is valid.");
        }
    }
}
