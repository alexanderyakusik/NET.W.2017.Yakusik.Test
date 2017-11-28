using Task5.Solution.DocumentPartVisitors;

namespace Task5.Console
{
    using System.Collections.Generic;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            List<DocumentPart> parts = new List<DocumentPart>
                {
                    new PlainText {Text = "Some plain text"},
                    new Hyperlink {Text = "google.com", Url = "https://www.google.by/"},
                    new BoldText {Text = "Some bold text"}
                };

            Document document = new Document(parts);

            var htmlConverter = new DocumentHtmlConverter();

            Console.WriteLine(document.Convert(htmlConverter));

            var latexConverter = new DocumentLaTeXConverter();

            Console.WriteLine(document.Convert(latexConverter));

            var plainTextConverter = new DocumentPlainTextConverter();

            Console.WriteLine(document.Convert(plainTextConverter));

            Console.ReadLine();
        }
    }
}
