namespace Task5.Solution.DocumentPartVisitors
{
    public class DocumentPlainTextConverter : AbstractDocumentConverter
    {
        public override void Visit(BoldText boldText)
        {
            convertedDocument += "**" + boldText.Text + "**";
        }

        public override void Visit(Hyperlink hyperlink)
        {
            convertedDocument += hyperlink.Text + " [" + hyperlink.Url + "]";
        }

        public override void Visit(PlainText plainText)
        {
            convertedDocument += plainText.Text;
        }
    }
}
