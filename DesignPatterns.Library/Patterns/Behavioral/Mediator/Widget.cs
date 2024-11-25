namespace DesignPatterns.Library.Patterns.Behavioral.Mediator
{
    public abstract class Widget
    {
        private DialogDirector _director;

        protected Widget(DialogDirector director)
        {
            _director = director;
        }

        public void Changed()
        {
            _director.WidgetChanged(this);
        }
    }
}
