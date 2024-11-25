namespace DesignPatterns.Library.Patterns.Behavioral.Command
{
    public class Document
    {
        private readonly string _name;

        public Document(string name)
        {
            _name = name;
        }

        public void Open() 
        {
            Console.WriteLine($"Opening document '{_name}'");
        }

        public void Close()
        {
            Console.WriteLine($"Closing document '{_name}'");
        }

        public void Paste()
        {
            Console.WriteLine($"Pasting document '{_name}'");
        }
    }
}
