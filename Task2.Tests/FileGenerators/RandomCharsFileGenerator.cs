﻿using System;
using System.Linq;
using System.Text;
using Task2.Solution;

namespace Task2.Console.FileGenerators
{
    public class RandomCharsFileGenerator : AbstractFileGenerator
    {
        public override string WorkingDirectory { get; protected set; } = "Files with random chars";

        public override string FileExtension { get; protected set; } = ".txt";

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var generatedString = this.RandomString(contentLength);

            var bytes = Encoding.Unicode.GetBytes(generatedString);

            return bytes;
        }

        private string RandomString(int Size)
        {
            var random = new Random();

            const string input = "abcdefghijklmnopqrstuvwxyz0123456789";

            var chars = Enumerable.Range(0, Size).Select(x => input[random.Next(0, input.Length)]);

            return new string(chars.ToArray());
        }
    }
}
