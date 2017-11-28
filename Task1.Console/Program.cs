using Task1.Console.Repositories;
using Task1.Console.Validators;
using Task1.Solution;

namespace Task1.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var repository = new SqlRepository();

            var passwordCheckerService = new PasswordCheckerService(repository);

            var longPasswordValidator = new LongPasswordValidator();

            passwordCheckerService.ValidatePassword("qweasd", longPasswordValidator);
        }
    }
}
