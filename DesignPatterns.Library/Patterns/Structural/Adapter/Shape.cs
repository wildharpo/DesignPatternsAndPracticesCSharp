using DesignPatterns.Library.Patterns.Structural.Adapter.Support;

namespace DesignPatterns.Library.Patterns.Structural.Adapter
{
    public abstract class Shape
    {
        public abstract IEnumerable<CoordinatePair> BoundingBox();
        public abstract Manipulator CreateManipulator();
    }
}
