using System.Drawing;

namespace DesignPatterns.Library.Patterns.Structural.Flyweight
{
    public class Character : Glyph
    {
        private char _charcode;

        public Character(char c)
        {
            _charcode = c;
        }

        public override Glyph Current(GlyphContext glyphContext)
        {
            throw new NotImplementedException();
        }

        public override void Draw(Window window, GlyphContext glyphContext)
        {
            var fontToUse = glyphContext.GetFont();
            var fontName = fontToUse.Name;
            var isItalic = fontToUse.Italic ? " Italic" : "";
            var isBold = fontToUse.Bold ? " Bold" : "";
            var fontSize = fontToUse.Size;
            var fontNameWithFamily = $"{fontName}{isItalic}{isBold} {fontSize}";
            Console.WriteLine($"Drawing character '{_charcode}' with font '{fontNameWithFamily}'");
            glyphContext.Next();
        }

        public override void First(GlyphContext glyphContext)
        {
            throw new NotImplementedException();
        }

        public override Font GetFont(GlyphContext glyphContext)
        {
            return glyphContext.GetFont();
        }

        public override void Insert(Glyph glyph, GlyphContext glyphContext)
        {
            throw new NotImplementedException();
        }

        public override bool IsDone(GlyphContext glyphContext)
        {
            throw new NotImplementedException();
        }

        public override void Next(GlyphContext glyphContext)
        {
            throw new NotImplementedException();
        }

        public override void Remove(GlyphContext glyphContext)
        {
            throw new NotImplementedException();
        }

        public override void SetFont(Font font, GlyphContext glyphContext)
        {
            glyphContext.SetFont(font);
        }
    }
}
