using Task2.Console.FileGenerators;
using Task2.Solution;

namespace Task2.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AbstractFileGenerator charGenerator;

            charGenerator = new RandomCharsFileGenerator();
            
            charGenerator.GenerateFiles(1, 10);

            charGenerator = new RandomBytesFileGenerator();

            charGenerator.GenerateFiles(10, 15);
        }
    }
}
