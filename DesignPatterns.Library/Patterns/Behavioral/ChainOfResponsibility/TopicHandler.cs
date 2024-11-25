namespace DesignPatterns.Library.Patterns.Behavioral.ChainOfResponsibility
{
    public static class TopicHandler
    {
        public static void DisplayHelp(Topic topic)
        {
            switch (topic) {
                case Topic.PAPER_ORIENTATION_TOPIC:
                    Console.WriteLine("Here is some help on paper orientation.");
                    break;
                case Topic.PRINT_TOPIC:
                    Console.WriteLine("Here is some help on printing.");
                    break;
                case Topic.APPLICATION_TOPIC:
                    Console.WriteLine("Here is some application-level help.");
                    break;
                default:
                    throw new Exception("Invalid topic speicifed.");
            }
        }
    }
}
