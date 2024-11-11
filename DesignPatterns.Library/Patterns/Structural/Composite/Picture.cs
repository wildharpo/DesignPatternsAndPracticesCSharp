namespace DesignPatterns.Library.Patterns.Structural.Composite
{
    public class Picture : Graphic
    {
        private List<Graphic> _graphics;

        public Picture()
        {
            _graphics = new List<Graphic>();
        }

        public override void Add(Graphic graphic)
        {
            _graphics.Add(graphic);
        }

        public override void Draw()
        {
            foreach (var graphic in _graphics)
                graphic.Draw();
        }

        public override Graphic GetChild(int index)
        {
            return _graphics[index];
        }

        public override void Remove(Graphic graphic)
        {
            _graphics.Remove(graphic);
        }
    }
}
