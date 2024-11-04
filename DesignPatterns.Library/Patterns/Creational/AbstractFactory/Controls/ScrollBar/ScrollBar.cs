namespace DesignPatterns.Library.Patterns.Creational.AbstractFactory.Controls.ScrollBar
{
    public abstract class ScrollBar
    {
        public abstract string BackColor { get; set; }
        public abstract string ForeColor { get; set; }
        public abstract string Cursor { get; set; }
        public abstract double TrackWidth { get; set; }
        public abstract bool RoundedCorners { get; set; }
    }
}
