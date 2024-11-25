namespace DesignPatterns.Library.Patterns.Behavioral.Command
{
    public class Menu
    {
        private List<MenuItem> _menuItems;

        public Menu()
        {
            _menuItems = new List<MenuItem>();
        }

        public void Add(MenuItem menuItem)
        {
            _menuItems.Add(menuItem);
        }
    }
}
