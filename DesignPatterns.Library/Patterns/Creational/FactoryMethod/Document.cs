namespace DesignPatterns.Library.Patterns.Creational.FactoryMethod
{
    public abstract class Document
    {
        public abstract void Open();
        public abstract void Close();
        
        public void Save()
        {
            // Add save logic
        }

        public void Revert()
        {
            // Add revert logic
        }
    }
}
