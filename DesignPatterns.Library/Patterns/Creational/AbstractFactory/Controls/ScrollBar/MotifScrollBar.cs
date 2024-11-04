namespace DesignPatterns.Library.Patterns.Creational.AbstractFactory.Controls.ScrollBar
{
    public class MotifScrollBar : ScrollBar
    {
        private string _backColor;
        private string _foreColor;
        private string _cursor;
        private double _trackWidth;
        private bool _roundedCorners;

        public MotifScrollBar()
        {
            _backColor = "#C0C0C0";
            _foreColor = "#666666";
            _cursor = "Hand";
            _trackWidth = 3;
            _roundedCorners = true;
        }

        public override string BackColor { get => _backColor; set => _backColor = value; }
        public override string ForeColor { get => _foreColor; set => _foreColor = value; }
        public override string Cursor { get => _cursor; set => _cursor = value; }
        public override double TrackWidth { get => _trackWidth; set => _trackWidth = value; }
        public override bool RoundedCorners { get => _roundedCorners; set => _roundedCorners = value; }
    }
}
