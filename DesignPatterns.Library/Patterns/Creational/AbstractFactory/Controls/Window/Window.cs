namespace DesignPatterns.Library.Patterns.Creational.AbstractFactory.Controls.Window
{
    public abstract class Window
    {
        public abstract string BackgroundColor { get; set; }
        public abstract string ForegroundColor { get; set; }
        public abstract double Margin { get; set; }
        public abstract double Padding { get; set; }
        public abstract bool RoundCorners { get; set; }
        public abstract bool Resizeable { get; set; }
    }
}
