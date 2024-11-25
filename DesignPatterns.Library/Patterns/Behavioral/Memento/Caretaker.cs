namespace DesignPatterns.Library.Patterns.Behavioral.Memento
{
    public class Caretaker
    {
        private Originator _originator;
        private List<Memento> _mementos;

        public Caretaker(Originator originator)
        {
            _originator = originator;
            _mementos = new List<Memento>();
        }

        public void Backup()
        {
            _mementos.Add(_originator.CreateMemento());
        }

        public void AddMemento(Memento memento)
        {
            _mementos.Add(memento);
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
                return;

            var lastMemento = _mementos.Last();
            _mementos.Remove(lastMemento);

            _originator.SetMemento(lastMemento);
        }

        public void ShowHistory()
        {
            Console.WriteLine("Value history: ");
            foreach(var memento in _mementos)
                Console.WriteLine(memento.GetState());
        }
    }
}
