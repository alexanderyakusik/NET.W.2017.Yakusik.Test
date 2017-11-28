using System;
using Task1.Solution.PasswordValidators;
using Task1.Solution.Repositories;

namespace Task1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IRepository _repository;

        public PasswordCheckerService(IRepository repository)
        {
            this._repository = repository;
        }

        public Tuple<bool, string> ValidatePassword(string password, IPasswordValidator passwordValidator)
        {
            var result = passwordValidator.Validate(password);

            if (result.Item1)
            {
                this._repository.Create(password);
            }

            return result;
        }
    }
}
