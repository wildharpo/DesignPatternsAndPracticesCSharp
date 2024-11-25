namespace DesignPatterns.Library.Patterns.Behavioral.ChainOfResponsibility
{
    public class Application : HelpHandler
    {
        public Application(Topic topic) : base(null, topic)
        {
        }

        public override void HandleHelp()
        {
            Console.WriteLine("The following help options exist:");
            var topics = Enum.GetValues(typeof(Topic));
            foreach (var topic in topics)
                Console.WriteLine(topic.ToString());
        }
    }
}
