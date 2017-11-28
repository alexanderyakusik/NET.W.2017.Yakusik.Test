namespace Task5.Solution.DocumentPartVisitors
{
    public class DocumentLaTeXConverter : AbstractDocumentConverter
    {
        public override void Visit(BoldText boldText)
        {
            convertedDocument += "\\textbf{" + boldText.Text + "}";
        }

        public override void Visit(Hyperlink hyperlink)
        {
            convertedDocument += "\\href{" + hyperlink.Url + "}{" + hyperlink.Text + "}";
        }

        public override void Visit(PlainText plainText)
        {
            convertedDocument += plainText.Text;
        }
    }
}
