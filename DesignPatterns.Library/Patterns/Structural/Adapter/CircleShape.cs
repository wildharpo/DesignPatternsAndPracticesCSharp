using DesignPatterns.Library.Patterns.Structural.Adapter.Support;

namespace DesignPatterns.Library.Patterns.Structural.Adapter
{
    public class CircleShape : Shape
    {
        public override IEnumerable<CoordinatePair> BoundingBox()
        {
            return new List<CoordinatePair>
            {
                new CoordinatePair(18, 10),
                new CoordinatePair(17, 12),
                new CoordinatePair(16, 14),
                new CoordinatePair(14, 16),
                new CoordinatePair(12, 17),
                new CoordinatePair(10, 18),
                new CoordinatePair(8, 17),
                new CoordinatePair(6, 16),
                new CoordinatePair(4, 14),
                new CoordinatePair(3, 12),
                new CoordinatePair(2, 10),
                new CoordinatePair(3, 8),
                new CoordinatePair(4, 6),
                new CoordinatePair(6, 4),
                new CoordinatePair(8, 3),
                new CoordinatePair(10, 2),
                new CoordinatePair(12, 3),
                new CoordinatePair(14, 4),
                new CoordinatePair(16, 6),
                new CoordinatePair(17, 8)
            };
        }

        public override Manipulator CreateManipulator()
        {
            throw new NotImplementedException();
        }
    }
}
