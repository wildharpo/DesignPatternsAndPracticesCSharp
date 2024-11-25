namespace DesignPatterns.Library.Patterns.Behavioral.Mediator
{
    public class FontDialogDirector : DialogDirector
    {
        private List<Widget> _widgets;

        public List<Widget> Widgets { get { return _widgets; } }

        public FontDialogDirector()
        {
            _widgets = new List<Widget>();
        }

        public override void CreateWidgets()
        {
            _widgets.Add(new ListBox(this));
            _widgets.Add(new EntryField(this));
        }

        public override void WidgetChanged(Widget widget)
        {
            if(widget.GetType() == typeof(ListBox)) 
            {
                var selectedValue = ((ListBox)widget).GetSelection();
                var textEntryWidget = _widgets.First(w => w.GetType() == typeof(EntryField));
                ((EntryField)textEntryWidget).SetText(selectedValue);
            }
        }
    }
}
