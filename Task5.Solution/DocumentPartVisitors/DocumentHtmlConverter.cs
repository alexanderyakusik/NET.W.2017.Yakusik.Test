namespace Task5.Solution.DocumentPartVisitors
{
    public class DocumentHtmlConverter : AbstractDocumentConverter
    {
        public override void Visit(BoldText boldText)
        {
            ConvertedDocument += "<b>" + boldText.Text + "</b>";
        }

        public override void Visit(Hyperlink hyperlink)
        {
            ConvertedDocument += "<a href=\"" + hyperlink.Url + "\">" + hyperlink.Text + "</a>";
        }

        public override void Visit(PlainText plainText)
        {
            ConvertedDocument += plainText.Text;
        }
    }
}
