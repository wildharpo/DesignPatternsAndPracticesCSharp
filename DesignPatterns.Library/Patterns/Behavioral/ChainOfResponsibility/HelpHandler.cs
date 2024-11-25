namespace DesignPatterns.Library.Patterns.Behavioral.ChainOfResponsibility
{
    public abstract class HelpHandler
    {
        private readonly HelpHandler _successor;
        private readonly Topic _topic;

        public HelpHandler(HelpHandler helpHandler, Topic topic = Topic.NO_HELP_TOPIC) 
        {
            _successor = helpHandler;
            _topic = topic;
        }

        public virtual bool HasHelp()
        {
            return _topic != Topic.NO_HELP_TOPIC;
        }

        public virtual void HandleHelp()
        {
            if (_successor != null)
                _successor.HandleHelp();
        }
    }
}
