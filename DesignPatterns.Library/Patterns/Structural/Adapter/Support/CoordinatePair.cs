namespace DesignPatterns.Library.Patterns.Structural.Adapter.Support
{
    public class CoordinatePair
    {
        public double X { get; set; }
        public double Y { get; set; }

        public CoordinatePair (double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
