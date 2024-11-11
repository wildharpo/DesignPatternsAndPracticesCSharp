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
            // custom logic here to draw a scrollbar
        }

        public override void Resize()
        {
            // resize the scrollbar
        }

        public void ScrollTo()
        {
            // scroll to a particular point
        }
    }
}
