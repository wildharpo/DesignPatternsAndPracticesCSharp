namespace DesignPatterns.Library.Patterns.Behavioral.Observer
{
    public abstract class ChangeManager
    {
        private List<SubjectObserverMapping> _registrations;

        public List<SubjectObserverMapping> Registrations { get {  return _registrations; } }

        protected ChangeManager()
        {
            _registrations = new List<SubjectObserverMapping>();
        }

        public abstract void Register(Subject subject, Observer observer);
        public abstract void Unregister(Subject subject, Observer observer);
        public abstract void Notify();
    }
}
