using System;
using Task1.Solution.PasswordValidators;

namespace Task1.Console.Validators
{
    public class LongPasswordValidator : IPasswordValidator
    {
        public Tuple<bool, string> Validate(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException($"{nameof(password)} cannot be null.");
            }

            if (password.Length < 10)
            {
                return Tuple.Create(false, $"{password} is too short.");
            }

            return Tuple.Create(true, $"{password} is valid.");
        }
    }
}
