using DesignPatterns.Library.Patterns.Structural.Flyweight;
using System.Drawing;
using Window = DesignPatterns.Library.Patterns.Structural.Flyweight.Window;

namespace DesignPatterns.Console.TestDrivers.Structural.Flyweight
{
    public static class FlyweightTestDriver
    {
        public static void RunTest()
        {
            var timesNewRoman12 = new Font("Times New Roman", 1);
            var timesNewRoman24 = new Font("Times New Roman", 2);
            var timesNewRoman12Italic = new Font("Times New Roman", 1, FontStyle.Italic);
            var timesNewRoman12Bold = new Font("Times New Roman", 1, FontStyle.Bold);
            var courier24 = new Font("Courier", 2);

            var characterGlyph_a = new Character('a');
            var characterGlyph_b = new Character('b');
            var characterGlyph_c = new Character('c');
            var characterGlyph_d = new Character('d');
            var characterGlyph_e = new Character('e');
            var characterGlyph_f = new Character('f');
            var characterGlyph_g = new Character('g');
            var characterGlyph_h = new Character('h');
            var characterGlyph_i = new Character('i');
            var characterGlyph_j = new Character('j');
            var characterGlyph_k = new Character('k');
            var characterGlyph_l = new Character('l');
            var characterGlyph_m = new Character('m');
            var characterGlyph_n = new Character('n');
            var characterGlyph_o = new Character('o');
            var characterGlyph_p = new Character('p');
            var characterGlyph_q = new Character('q');
            var characterGlyph_r = new Character('r');
            var characterGlyph_s = new Character('s');
            var characterGlyph_t = new Character('t');
            var characterGlyph_u = new Character('u');
            var characterGlyph_v = new Character('v');
            var characterGlyph_w = new Character('w');
            var characterGlyph_x = new Character('x');
            var characterGlyph_y = new Character('y');
            var characterGlyph_z = new Character('z');
            var characterGlyph_hyphen = new Character('-');
            // etc...

            var glyphContext = new GlyphContext();
            var window = new Window();
            glyphContext.SetFont(timesNewRoman24, 1);
            characterGlyph_o.Draw(window, glyphContext);
            glyphContext.SetFont(timesNewRoman12, 187);
            characterGlyph_b.Draw(window, glyphContext);
            characterGlyph_j.Draw(window, glyphContext);
            characterGlyph_e.Draw(window, glyphContext);
            characterGlyph_c.Draw(window, glyphContext);
            characterGlyph_t.Draw(window, glyphContext);
            characterGlyph_hyphen.Draw(window, glyphContext);
            characterGlyph_o.Draw(window, glyphContext);
            // etc...
        }
    }
}
