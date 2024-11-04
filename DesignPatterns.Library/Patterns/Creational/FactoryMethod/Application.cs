namespace DesignPatterns.Library.Patterns.Creational.FactoryMethod
{
    public abstract class Application
    {
        private List<Document> _docs;

        protected Application()
        {
            _docs = new List<Document>();
        }

        public abstract Document CreateDocument();

        public void NewDocument()
        {
            Document doc = CreateDocument();
            _docs.Add(doc);
            doc.Open();
        }

        public void OpenDocument()
        {
            _docs.First().Open();
        }
    }
}
