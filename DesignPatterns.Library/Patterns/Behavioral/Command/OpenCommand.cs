using System.Reflection.Metadata;

namespace DesignPatterns.Library.Patterns.Behavioral.Command
{
    public class OpenCommand : Command
    {
        private readonly Application _application;
        private string _response;

        public OpenCommand(Application application)
        {
            _application = application;
        }

        protected virtual string AskUser() 
        {
            Console.Write("Please enter the full path of the file you would like to open: ");
            var documentName = Console.ReadLine();
            return documentName;
        }

        public override void Execute()
        {
            var name = AskUser();

            if (name != null)
            {
                var document = new Document(name);
                _application.Add(document);
                document.Open();
            }
        }
    }
}
