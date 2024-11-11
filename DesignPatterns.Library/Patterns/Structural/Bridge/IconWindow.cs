namespace DesignPatterns.Library.Patterns.Structural.Bridge
{
    public class IconWindow : Window
    {
        public IconWindow(WindowImp implementation) : base(implementation)
        {
        }

        public void DrawBorder()
        {
            base.DrawRectangle();
            base.DrawText();
        }
    }
}
