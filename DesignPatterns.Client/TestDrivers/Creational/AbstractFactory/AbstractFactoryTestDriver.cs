using DesignPatterns.Library.Patterns.Creational.AbstractFactory;

namespace DesignPatterns.Client.TestDrivers.Creational.AbstractFactory
{
    public static class AbstractFactoryTestDriver
    {
        public static void TestMotifLookAndFeel()
        {
            var factory = new MotifWidgetFactory();
            var scrollBar = factory.CreateScrollBar();
            var window = factory.CreateWindow();

            System.Console.WriteLine("Motif settings:");
            System.Console.WriteLine("Scrollbar:");
            System.Console.WriteLine($"Background color = '{scrollBar.BackColor}'");
            System.Console.WriteLine($"Foreground color = '{scrollBar.ForeColor}'");
            System.Console.WriteLine($"Cursor = '{scrollBar.Cursor}'");
            System.Console.WriteLine($"TrackWidth = '{scrollBar.TrackWidth}'");
        }
    }
}
