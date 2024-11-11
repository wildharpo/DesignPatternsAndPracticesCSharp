namespace DesignPatterns.Library.Patterns.Structural.Decorator
{
    public abstract class Decorator : VisualComponent
    {
        private VisualComponent _component;

        protected Decorator(VisualComponent component)
        {
            _component = component;
        }

        public override void Draw()
        {
            _component.Draw();
        }
    }
}
