using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Structural.Decorator
{
    public class BorderDecorator : Decorator
    {
        public BorderDecorator(VisualComponent component) : base(component)
        {
        }

        public override void Draw()
        {
            base.Draw();
            DrawBorder();
        }

        public void DrawBorder()
        {
            // draw a custom border
        }

        public override void Resize()
        {
            throw new NotImplementedException();
        }
    }
}
