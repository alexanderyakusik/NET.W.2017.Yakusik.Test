namespace Task5.Solution.DocumentPartVisitors
{
    public class DocumentPlainTextConverter : AbstractDocumentConverter
    {
        public override void Visit(BoldText boldText)
        {
            ConvertedDocument += "**" + boldText.Text + "**";
        }

        public override void Visit(Hyperlink hyperlink)
        {
            ConvertedDocument += hyperlink.Text + " [" + hyperlink.Url + "]";
        }

        public override void Visit(PlainText plainText)
        {
            ConvertedDocument += plainText.Text;
        }
    }
}
