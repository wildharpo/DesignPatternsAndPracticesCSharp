namespace DesignPatterns.Library.Patterns.Creational.Prototype
{
    public class GraphicTool : Tool
    {
        private Graphic _graphic;

        public GraphicTool(Graphic graphic)
        {
            _graphic = graphic;
        }

        public override void Manipulate()
        {
            var prototype = _graphic.Clone();
            prototype.Draw();
        }
    }
}
