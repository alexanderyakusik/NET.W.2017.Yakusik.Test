using Task5.Solution;

namespace Task5
{
    public abstract class DocumentPart
    {
        public abstract void Accept(IDocumentPartVisitor documentPartVisitor);

        public string Text { get; set; }
    }
}
