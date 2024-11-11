using DesignPatterns.Library.Patterns.Structural.Adapter.Support;

namespace DesignPatterns.Library.Patterns.Structural.Adapter
{
    public class TextShape : Shape
    {
        private TextView _textView;

        public TextShape()
        {
            _textView = new TextView();
        }

        public override IEnumerable<CoordinatePair> BoundingBox()
        {
            return _textView.GetExtent();
        }

        public override Manipulator CreateManipulator()
        {
            return new TextManipulator();
        }
    }
}
