using DesignPatterns.Library.Patterns.Structural.Proxy.Support;

namespace DesignPatterns.Library.Patterns.Structural.Proxy
{
    public class Image : Graphic
    {
        private string _filePath;

        public Image(string filePath)
        {
            _filePath = filePath;
            Console.WriteLine("Creating image...");
            Thread.Sleep(4000);
            Console.WriteLine("Image created!");
        }

        public override void Draw(Point point)
        {
            Console.WriteLine("Drawing image...");
        }

        public override Point GetExtent()
        {
            throw new NotImplementedException();
        }

        public override void HandleMouse(Event mouseEvent)
        {
            throw new NotImplementedException();
        }

        public override void Load(MemoryStream to)
        {
            throw new NotImplementedException();
        }

        public override void Store(MemoryStream from)
        {
            throw new NotImplementedException();
        }
    }
}
