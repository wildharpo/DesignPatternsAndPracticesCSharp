namespace DesignPatterns.Library.Patterns.Creational.Prototype
{
    public abstract class Graphic
    {
        public abstract void Draw();

        public abstract Graphic Clone();
    }
}
