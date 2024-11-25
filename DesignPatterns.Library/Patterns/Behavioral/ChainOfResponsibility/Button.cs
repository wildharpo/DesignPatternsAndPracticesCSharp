namespace DesignPatterns.Library.Patterns.Behavioral.ChainOfResponsibility
{
    public class Button : Widget
    {
        private readonly Topic _topic;

        public Button(Widget parent, Topic topic = Topic.NO_HELP_TOPIC) : base(parent, topic)
        {
            _topic = topic;
        }

        public override void HandleHelp()
        {
            if (base.HasHelp())
                TopicHandler.DisplayHelp(_topic);
            else
                base.HandleHelp();
        }
    }
}
