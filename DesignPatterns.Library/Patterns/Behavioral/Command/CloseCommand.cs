namespace DesignPatterns.Library.Patterns.Behavioral.Command
{
    public class CloseCommand : Command
    {
        private readonly Application _application;

        public CloseCommand(Application application)
        {
            _application = application;
        }

        public override void Execute()
        {
            _application.Document.Close();
        }
    }
}
