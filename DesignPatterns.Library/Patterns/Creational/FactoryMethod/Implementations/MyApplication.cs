namespace DesignPatterns.Library.Patterns.Creational.FactoryMethod.Implementations
{
    public class MyApplication : Application
    {
        public override Document CreateDocument()
        {
            return new MyDocument();
        }
    }
}
