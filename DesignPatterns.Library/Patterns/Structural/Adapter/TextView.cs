using DesignPatterns.Library.Patterns.Structural.Adapter.Support;

namespace DesignPatterns.Library.Patterns.Structural.Adapter
{
    /// <summary>
    /// For the sake of the example, we must assume that this TextView class came from a third-party source such that
    /// we do not have access to the source code. We can't change it, but we *can* adapt it.
    /// </summary>
    public class TextView
    {
        private IEnumerable<CoordinatePair> _extent;
        private string _text;

        public TextView()
        {
            _extent = new List<CoordinatePair>
            {
                new CoordinatePair(0, 0),
                new CoordinatePair(100, 0),
                new CoordinatePair(100, 50),
                new CoordinatePair(0, 50)
            };
            _text = "SampleText";
        }

        public IEnumerable<CoordinatePair> GetExtent()
        {
            return _extent;
        }
    }
}
