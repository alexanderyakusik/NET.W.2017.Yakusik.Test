namespace Task5.Solution.DocumentPartVisitors
{
    public class DocumentHtmlConverter : AbstractDocumentConverter
    {
        public override void Visit(BoldText boldText)
        {
            convertedDocument += "<b>" + boldText.Text + "</b>";
        }

        public override void Visit(Hyperlink hyperlink)
        {
            convertedDocument += "<a href=\"" + hyperlink.Url + "\">" + hyperlink.Text + "</a>";
        }

        public override void Visit(PlainText plainText)
        {
            convertedDocument += plainText.Text;
        }
    }
}
