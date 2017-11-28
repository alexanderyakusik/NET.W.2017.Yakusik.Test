namespace Task5.Solution.DocumentPartVisitors
{
    public class DocumentLaTeXConverter : AbstractDocumentConverter
    {
        public override void Visit(BoldText boldText)
        {
            ConvertedDocument += "\\textbf{" + boldText.Text + "}";
        }

        public override void Visit(Hyperlink hyperlink)
        {
            ConvertedDocument += "\\href{" + hyperlink.Url + "}{" + hyperlink.Text + "}";
        }

        public override void Visit(PlainText plainText)
        {
            ConvertedDocument += plainText.Text;
        }
    }
}
