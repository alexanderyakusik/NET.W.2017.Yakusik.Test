using System;
using System.Collections.Generic;
using Task5.Solution.DocumentPartVisitors;

namespace Task5
{
    public class Document
    {
        private List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this.parts = new List<DocumentPart>(parts);
        }

        public string Convert(AbstractDocumentConverter converter)
        {
            return converter.GetConvertedDocument(parts);
        }
    }
}
