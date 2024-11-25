namespace DesignPatterns.Library.Patterns.Behavioral.Memento
{
    public class Memento
    {
        private int _state;

        public Memento(int state)
        {
            _state = state;
        }

        public void SetState(int state)
        {
            _state = state;
        }

        public int GetState()
        {
            return _state;
        }
    }
}
