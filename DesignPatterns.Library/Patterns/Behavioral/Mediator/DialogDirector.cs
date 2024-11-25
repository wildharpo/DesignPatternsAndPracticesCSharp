namespace DesignPatterns.Library.Patterns.Behavioral.Mediator
{
    public abstract class DialogDirector
    {
        public void ShowDialog()
        {
            Console.WriteLine("Dialog displayed");
        }

        public abstract void CreateWidgets();
        public abstract void WidgetChanged(Widget widget);
    }
}
