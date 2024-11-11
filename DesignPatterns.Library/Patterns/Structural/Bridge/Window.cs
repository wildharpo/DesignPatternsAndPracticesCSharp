namespace DesignPatterns.Library.Patterns.Structural.Bridge
{
    public abstract class Window
    {
        private WindowImp _implementation;

        protected Window(WindowImp implementation)
        {
            _implementation = implementation;
        }

        public void DrawText()
        {
            _implementation.DevDrawText();
        }

        public void DrawRectangle()
        {
            _implementation.DevDrawLine();
            _implementation.DevDrawLine();
            _implementation.DevDrawLine();
            _implementation.DevDrawLine();
        }
    }
}
