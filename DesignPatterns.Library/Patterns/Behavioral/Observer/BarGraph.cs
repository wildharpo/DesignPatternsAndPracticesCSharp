namespace DesignPatterns.Library.Patterns.Behavioral.Observer
{
    public class BarGraph : Observer
    {
        public int ObserverValue { get; private set; }

        public BarGraph()
        {
            ObserverValue = 1;
        }

        public override void Update(Subject subject)
        {
            ObserverValue = subject.SubjectValue;
        }
    }
}
