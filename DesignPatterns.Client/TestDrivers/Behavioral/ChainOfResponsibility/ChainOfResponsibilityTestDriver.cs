using DesignPatterns.Library.Patterns.Behavioral.ChainOfResponsibility;

namespace DesignPatterns.Console.TestDrivers.Behavioral.ChainOfResponsibility
{
    public static class ChainOfResponsibilityTestDriver
    {
        public static void RunTest()
        {
            // Each GUI component will either print its help topic if it has
            // one, or will pass the request along in the chain of handlers 
            // until 
            var application = new Application(Topic.APPLICATION_TOPIC);
            var dialog = new Dialog(application, Topic.PRINT_TOPIC);
            var button = new Button(dialog, Topic.PAPER_ORIENTATION_TOPIC);
            var button2 = new Button(dialog, Topic.NO_HELP_TOPIC);

            var dialog2 = new Dialog(application, Topic.NO_HELP_TOPIC);
            var button3 = new Button(dialog, Topic.NO_HELP_TOPIC);

            button.HandleHelp();
            button2.HandleHelp();
            button3.HandleHelp();
        }
    }
}
