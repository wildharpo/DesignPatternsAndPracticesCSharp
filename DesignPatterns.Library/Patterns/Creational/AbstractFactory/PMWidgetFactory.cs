using DesignPatterns.Library.Patterns.Creational.AbstractFactory.Controls.ScrollBar;
using DesignPatterns.Library.Patterns.Creational.AbstractFactory.Controls.Window;

namespace DesignPatterns.Library.Patterns.Creational.AbstractFactory
{
    public class PMWidgetFactory : WidgetFactory
    {
        public override ScrollBar CreateScrollBar()
        {
            return new PMScrollBar();
        }

        public override Window CreateWindow()
        {
            return new PMWindow();
        }
    }
}
