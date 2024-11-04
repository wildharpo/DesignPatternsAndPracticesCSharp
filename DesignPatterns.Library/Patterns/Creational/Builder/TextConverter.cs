namespace DesignPatterns.Library.Patterns.Creational.Builder
{
    public abstract class TextConverter
    {
        public abstract void ConvertCharacter(char character);
        public abstract void ConvertFontChange(string font);
        public abstract void ConvertParagraph(string paragraph);
    }
}
