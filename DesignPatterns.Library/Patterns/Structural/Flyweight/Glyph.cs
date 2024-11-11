using DesignPatterns.Library.Patterns.Creational.AbstractFactory.Controls.Window;
using System.Drawing;

namespace DesignPatterns.Library.Patterns.Structural.Flyweight
{
    public abstract class Glyph
    {
        public abstract void Draw(Window window, GlyphContext glyphContext);
        public abstract void SetFont(Font font, GlyphContext glyphContext);
        public abstract Font GetFont(GlyphContext glyphContext);
        public abstract void First(GlyphContext glyphContext);
        public abstract void Next(GlyphContext glyphContext);
        public abstract bool IsDone(GlyphContext glyphContext);
        public abstract Glyph Current(GlyphContext glyphContext);
        public abstract void Insert(Glyph glyph, GlyphContext glyphContext);
        public abstract void Remove(GlyphContext glyphContext);
    }
}
