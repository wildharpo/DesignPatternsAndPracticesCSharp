namespace DesignPatterns.Library.Patterns.Behavioral.Command
{
    public class Application
    {
        private Document _document;
        public Document Document { get { return _document; } }

        private List<Menu> _menus;

        public Application()
        {
            _menus = new List<Menu>();
        }

        public void Add(Document document)
        {
            _document = document;
        }

        public void AddMenu(Menu menu)
        {
            _menus.Add(menu);
        }
    }
}
