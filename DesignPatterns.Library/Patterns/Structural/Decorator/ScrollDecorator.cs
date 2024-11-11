namespace DesignPatterns.Library.Patterns.Structural.Decorator
{
    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(VisualComponent component) : base(component)
        {
        }

        public override void Draw()
        {
            base.Draw();
            ScrollTo();
        }

        public void ScrollTo()
        {
            // draw a custom scroll bar
        }
    }
}
