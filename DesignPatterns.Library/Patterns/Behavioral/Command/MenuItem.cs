namespace DesignPatterns.Library.Patterns.Behavioral.Command
{
    public class MenuItem
    {
        private Command _command;

        public MenuItem(Command command)
        {
            _command = command;
        }

        public void Clicked()
        {
            _command.Execute();
        }
    }
}
