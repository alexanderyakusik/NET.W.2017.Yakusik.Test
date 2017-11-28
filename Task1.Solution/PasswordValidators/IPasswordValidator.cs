using System;

namespace Task1.Solution.PasswordValidators
{
    public interface IPasswordValidator
    {
        Tuple<bool, string> Validate(string password);
    }
}
