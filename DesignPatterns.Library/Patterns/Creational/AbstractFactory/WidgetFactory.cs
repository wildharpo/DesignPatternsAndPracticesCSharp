using DesignPatterns.Library.Patterns.Creational.AbstractFactory.Controls.ScrollBar;
using DesignPatterns.Library.Patterns.Creational.AbstractFactory.Controls.Window;

namespace DesignPatterns.Library.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// We want to 
    /// </summary>
    public abstract class WidgetFactory
    {
        public abstract ScrollBar CreateScrollBar();
        public abstract Window CreateWindow();
    }
}
