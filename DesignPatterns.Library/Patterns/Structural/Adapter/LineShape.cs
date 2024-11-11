using DesignPatterns.Library.Patterns.Structural.Adapter.Support;

namespace DesignPatterns.Library.Patterns.Structural.Adapter
{
    public class LineShape : Shape
    {
        private IEnumerable<CoordinatePair> _coordinatePairs;

        public LineShape()
        {
            _coordinatePairs = new List<CoordinatePair>
            {
                new CoordinatePair(10, 10),
                new CoordinatePair(60, 10)
            };
        }

        public override IEnumerable<CoordinatePair> BoundingBox()
        {
            return _coordinatePairs;
        }

        public override Manipulator CreateManipulator()
        {
            return new LineManipulator();
        }
    }
}
