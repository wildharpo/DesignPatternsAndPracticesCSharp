namespace DesignPatterns.Library.Patterns.Behavioral.Mediator
{
    public class EntryField : Widget
    {
        public string Text { get; private set; }

        public EntryField(DialogDirector director) : base(director)
        {
        }

        public void SetText(string value)
        {
            Text = value;
            Changed();
        }
    }
}
