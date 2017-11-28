using Task5.Solution;

namespace Task5
{
    public class BoldText : DocumentPart
    {
        public override void Accept(IDocumentPartVisitor documentPartVisitor)
        {
            documentPartVisitor.Visit(this);
        }
    }
}