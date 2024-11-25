using DesignPatterns.Library.Patterns.Behavioral.Command;

namespace DesignPatterns.Console.TestDrivers.Behavioral.Command
{
    public class MyClass : Receiver
    {
        public MyClass() 
        {
             base.SetAction(() => { System.Console.WriteLine("MyClass action invoked!"); });
        }
    }

    public static class CommandTestDriver
    {
        public static void RunTest()
        {
            // create an instance of our application
            var application = new Application();

            // set up our list of menu items and commands.
            // Let's have OpenCommand and CloseCommand for simplicity
            var openCommand = new OpenCommand(application);
            var closeCommand = new CloseCommand(application);

            // create MenuItems tied to these commands
            var openMenuItem = new MenuItem(openCommand);
            var closeMenuItem = new MenuItem(closeCommand);

            // create a Menu to hold these menu items
            var menu = new Menu();
            menu.Add(openMenuItem);
            menu.Add(closeMenuItem);

            // add the menu to our application
            application.AddMenu(menu);

            // simulate user clicking the "Open" button
            openMenuItem.Clicked();

            // simulate user clicking the "Close" button
            closeMenuItem.Clicked();
        }
    }
}
