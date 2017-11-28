using System.Collections.Generic;

namespace Task5.Solution.DocumentPartVisitors
{
    public abstract class AbstractDocumentConverter : IDocumentPartVisitor
    {
        protected string convertedDocument = string.Empty;

        public abstract void Visit(BoldText boldText);

        public abstract void Visit(Hyperlink hyperlink);

        public abstract void Visit(PlainText plainText);

        public string GetConvertedDocument(List<DocumentPart> parts)
        {
            foreach (var item in parts)
            {
                Visit((dynamic)item);
            }

            return convertedDocument;
        }
    }
}
