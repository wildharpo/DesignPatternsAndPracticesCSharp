namespace DesignPatterns.Library.Patterns.Creational.AbstractFactory.Controls.Window
{
    public class MotifWindow : Window
    {
        private string _backgroundColor;
        private string _foregroundColor;
        private double _margin;
        private double _padding;
        private bool _roundCorners;
        private bool _resizable;

        public MotifWindow()
        {
            _backgroundColor = "#C0C0C0";
            _foregroundColor = "#666666";
            _margin = 2;
            _padding = 1;
            _roundCorners = true;
            _resizable = true;
        }

        public override string BackgroundColor { get => _backgroundColor; set => _backgroundColor = value; }
        public override string ForegroundColor { get => _foregroundColor; set => _foregroundColor = value; }
        public override double Margin { get => _margin; set => _margin = value; }
        public override double Padding { get => _padding; set => _padding = value; }
        public override bool RoundCorners { get => _roundCorners; set => _roundCorners = value; }
        public override bool Resizeable { get => _resizable; set => _resizable = value; }
    }
}
