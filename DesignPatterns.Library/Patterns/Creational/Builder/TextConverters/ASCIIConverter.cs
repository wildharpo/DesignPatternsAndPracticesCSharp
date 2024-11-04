using System.Text;

namespace DesignPatterns.Library.Patterns.Creational.Builder.TextConverters
{
    public class ASCIIConverter : TextConverter
    {
        private List<byte> _bytes;

        public ASCIIConverter()
        {
            _bytes = new List<byte>();
        }

        public override void ConvertCharacter(char character)
        {
            var characterAsByte = (byte)character;
            _bytes.Add(characterAsByte);
        }

        public override void ConvertFontChange(string font)
        {
            // Do nothing, as an ASCII file does not contain font information
            return;
        }

        public override void ConvertParagraph(string paragraph)
        {
            var asciiBytes = Encoding.ASCII.GetBytes(paragraph);
            _bytes.AddRange(asciiBytes);
        }

        public string GetASCIIText()
        {
            return Encoding.ASCII.GetString(_bytes.ToArray());
        }
    }
}
