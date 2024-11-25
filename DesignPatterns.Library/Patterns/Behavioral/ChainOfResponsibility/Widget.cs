namespace DesignPatterns.Library.Patterns.Behavioral.ChainOfResponsibility
{
    public abstract class Widget : HelpHandler
    {
        private Widget _parent;

        protected Widget(Widget parent, Topic topic = Topic.NO_HELP_TOPIC) : base(parent, topic)
        {
            _parent = parent;
        }
    }
}
