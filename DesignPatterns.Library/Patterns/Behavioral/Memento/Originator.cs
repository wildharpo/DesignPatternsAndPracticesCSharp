namespace DesignPatterns.Library.Patterns.Behavioral.Memento
{
    public class Originator
    {
        private int _state;

        public Originator(int state)
        {
            _state = state;
        }

        public void DoSomething()
        {
            _state = new Random().Next();
        }

        // "Save" method
        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        // "Undo" method
        public void SetMemento(Memento memento)
        {
            _state = memento.GetState();
        }
    }
}
