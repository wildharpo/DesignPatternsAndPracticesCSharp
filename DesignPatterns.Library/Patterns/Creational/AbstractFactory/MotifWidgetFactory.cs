using DesignPatterns.Library.Patterns.Creational.AbstractFactory.Controls.ScrollBar;
using DesignPatterns.Library.Patterns.Creational.AbstractFactory.Controls.Window;

namespace DesignPatterns.Library.Patterns.Creational.AbstractFactory
{
    public class MotifWidgetFactory : WidgetFactory
    {
        public override ScrollBar CreateScrollBar()
        {
            return new MotifScrollBar();
        }

        public override Window CreateWindow()
        {
            return new MotifWindow();
        }
    }
}
