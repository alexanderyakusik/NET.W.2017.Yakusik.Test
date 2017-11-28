using System;
using Task2.Solution;

namespace Task2.Console.FileGenerators
{
    public class RandomBytesFileGenerator : AbstractFileGenerator
    {
        public override string WorkingDirectory { get; protected set; } = "Files with random bytes";

        public override string FileExtension { get; protected set; } = ".bytes";

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}
