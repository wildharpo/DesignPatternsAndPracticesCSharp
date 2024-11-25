namespace DesignPatterns.Library.Patterns.Behavioral.Mediator
{
    public class ListBox : Widget
    {
        private List<string> _list;
        private int _selectionIndex;

        public ListBox(DialogDirector director) : base(director)
        {
            _list = new List<string> { "This", "is", "a", "test" };
        }

        public string GetSelection()
        {
            return _list[_selectionIndex];
        }

        public void SelectItem(int index)
        {
            if (index >= 0 && index <= 3)
            {
                _selectionIndex = index;
                Changed();
            }
        }
    }
}
