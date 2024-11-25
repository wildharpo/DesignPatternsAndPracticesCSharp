namespace DesignPatterns.Library.Patterns.Behavioral.Observer
{
    public class Subject
    {
        private ChangeManager _changeManager;
        
        public int SubjectValue { get; private set; } = 0;

        public Subject(ChangeManager changeManager)
        {
            _changeManager = changeManager;
        }

        public void Attach(Observer observer)
        {
            _changeManager.Register(this, observer);
        }

        public void Detach(Observer observer)
        {
            _changeManager.Unregister(this, observer);
        }

        public void Notify()
        {
            _changeManager.Notify();
        }

        public void ChangeValue()
        {
            SubjectValue = new Random().Next();
            Notify();
        }
    }
}
