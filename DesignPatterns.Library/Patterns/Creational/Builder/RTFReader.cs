using GemBox.Document;
using System.Text.RegularExpressions;

namespace DesignPatterns.Library.Patterns.Creational.Builder
{
    public class RTFReader
    {
        private TextConverter _textConverter;

        public RTFReader(TextConverter textConverter)
        {
            _textConverter = textConverter;
        }

        public void ParseRTF()
        {
            GemBox.Document.ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            using (var ms = new MemoryStream())
            {
                var rtfBytes = System.Text.Encoding.ASCII.GetBytes(Properties.Resources.CSCI_0371_Syllabus_Brief);
                ms.Write(rtfBytes, 0, rtfBytes.Length);
                ms.Position = 0;
                var doc = DocumentModel.Load(ms);
                var docParagraphs = doc.GetChildElements(true, ElementType.Paragraph);
                foreach (var paragraph in docParagraphs)
                {
                    var textValue = paragraph.Content.ToString();
                    foreach (var character in textValue)
                        _textConverter.ConvertCharacter(character);
                }
            }
        }
    }
}
