namespace DesignPatterns.Library.Patterns.Behavioral.Observer
{
    public class SubjectObserverMapping
    {
        public Subject Subject { get; private set; }
        public Observer Observer { get; private set; }

        public SubjectObserverMapping(Subject subject, Observer observer)
        {
            Subject = subject;
            Observer = observer;
        }
    }
}
