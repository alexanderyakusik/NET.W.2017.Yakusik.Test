using Task5.Solution;
using Task5.Solution.DocumentPartVisitors;

namespace Task5
{
    public class Hyperlink : DocumentPart
    {
        public string Url { get; set; }

        public override void Accept(IDocumentPartVisitor documentPartVisitor)
        {
            documentPartVisitor.Visit(this);
        }
    }
}
